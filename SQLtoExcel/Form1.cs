using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SQLtoExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MariaDB_Connect_Librarys MDB_Lib = new MariaDB_Connect_Librarys();
        string message1 = "Success Connect";
        string message2 = "Faild Connect";
        string message3 = "Success Converted";
        string message4 = "Please select the type of table you want to export：";
        string Search_Column = "";
        string Search_condition = "";
        string Keyword = "";
        int Have_be_searching = 0;
        public static string Language = "English";
        DataTable dt1 = new DataTable();//所有資料
        DataTable dt2 = new DataTable();//搜尋後的資料
        DataTable dt_Cache = new DataTable();//一個頁數的顯示資料
        int B_Page_Limit = 100;//一個頁數最大的資料量
        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                int error = 0;
                error = MDB_Lib.MariaDB_Connect(Tbx_IP.Text,"none",Tbx_User.Text,Tbx_Passwd.Text,0);
                if(error == 0)
                {
                    MessageBox.Show(message1);
                    Gbx_DataSelect.Enabled = true;
                }
                else if(error == 1)
                {
                    MessageBox.Show(message2);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Cmb_schema_DropDown(object sender, EventArgs e)
        {
            Cmb_schema.Items.Clear();
            List<string> databases = new List<string>();
            MDB_Lib.Search_DataBases(databases);
            foreach(string s in databases)
            {
                Cmb_schema.Items.Add(s);
            }
        }

        private void Cmb_schema_SelectedIndexChanged(object sender, EventArgs e)
        {
            MDB_Lib.sqlcommand_no_receive("use " + Cmb_schema.SelectedItem.ToString());
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            Cmb_Tables.Items.Clear();
            MDB_Lib.MariaDB_Close_Open("Close");
            MDB_Lib.MariaDB_Close_Open("Open");
            List<string> Tables_Name = new List<string>();
            MDB_Lib.Search_DataTable(Tables_Name, Cmb_schema.SelectedItem.ToString());
            foreach (string tablename in Tables_Name)
            {
                Cmb_Tables.Items.Add(tablename);
            }
        }

        private void Btn_View_Table_Click(object sender, EventArgs e)
        {
            Have_be_searching = 0;
            dt_Cache.Clear();
            //dataGridView1 = new DataGridView();
            //查詢所有資料
            MDB_Lib.MariaDB_Connect(Tbx_IP.Text,Cmb_schema.SelectedItem.ToString(), Tbx_User.Text, Tbx_Passwd.Text, 1);
            MDB_Lib.SQL_To_DataSet( dt1, Cmb_Tables.SelectedItem.ToString());
            //分筆數
            int page_count = dt1.Rows.Count / B_Page_Limit;
            if(dt1.Rows.Count%B_Page_Limit != 0)
            {
                page_count += 1;
            }
            Cmb_Page_Count.Items.Clear();
            for (int i = 1; i <= page_count; i++)
            {
                Cmb_Page_Count.Items.Add(i.ToString());
            }
            //先顯示第一頁
            dt_Cache = dt1.Clone();//先複製他的格式(不是資料)
            for (int i = 0; i < B_Page_Limit; i++)
            {
                try
                {
                    dt_Cache.ImportRow(dt1.Rows[i]);
                }
                catch
                {

                }
            }
            Cmb_Page_Count.SelectedIndex = 0;
            dataGridView1.DataSource = dt_Cache;
            dataGridView1.MakeDoubleBuffered(true);
            Gbx_Search.Enabled = true;
        }

        public void Page_Data_Display_DT1()
        {
            dt_Cache.Clear();
            dt_Cache = dt1.Clone();//先複製他的格式(不是資料)
            int page = Cmb_Page_Count.SelectedIndex + 1;
            for (int i = 0 + (B_Page_Limit*(page -1)); i < (B_Page_Limit *page ); i++)
            {
                try
                {
                    dt_Cache.ImportRow(dt1.Rows[i]);
                }
                catch
                {

                }
            }
            dataGridView1.DataSource = dt_Cache;
            dataGridView1.MakeDoubleBuffered(true);
        }

        public void Page_Data_Display_DT2()
        {
            dt_Cache.Clear();
            dt_Cache = dt2.Clone();//先複製他的格式(不是資料)
            int page = Cmb_Page_Count.SelectedIndex + 1;
            for (int i = 0 + (B_Page_Limit * (page - 1)); i < (B_Page_Limit * page); i++)
            {
                try
                {
                    dt_Cache.ImportRow(dt2.Rows[i]);
                }
                catch
                {

                }
            }
            dataGridView1.DataSource = dt_Cache;
            dataGridView1.MakeDoubleBuffered(true);
        }

        private void Btn_Export_Excel_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            Gbx_Command.Enabled = false;
            Gbx_DataSelect.Enabled = false;
            Gbx_Account.Enabled = false;
                Form2 frm2 = new Form2();
            frm2.Have_Search_Flag = Have_be_searching;
                frm2.ShowDialog();
                int return_ans = frm2.return_asnwer();
                if(return_ans == 0)//整份資料
                {
                    MDB_Lib.SQLData_To_Excel(Cmb_Tables.SelectedItem.ToString(), progressBar1);
                }
                else if (return_ans == 1)//過濾資料(1)
                {
                    MDB_Lib.DataGirdView_To_Excel(dt2, progressBar1);
                }
                else if(return_ans == 2)
                {
                    MDB_Lib.DataGirdView_To_Excel(dt_Cache, progressBar1);
                }
            MessageBox.Show(message3);
            Gbx_Command.Enabled = true;
            Gbx_DataSelect.Enabled = true;
            Gbx_Account.Enabled = true;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }

        private void chineseTraditionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Language = "Chinese(Traditional)";
            Language_Set();
        }

        private void chineseSimplifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Language = "Chinese(Simplified)";
            Language_Set();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Language = "English";
            Language_Set();
        }

        public void Language_Set()//語言設定
        {
            switch(Language)
            {
                case "English":
                    Gbx_Account.Text = "MariaDB Account Information";
                    Lbl_IP.Text = "SQL IP Address：";
                    Lbl_User.Text = "User Name：";
                    Lbl_Passwd.Text = "Password：";
                    Btn_Connect.Text = "Connect";
                    Gbx_DataSelect.Text = "Schema andTable Select";
                    Lbl_Schema.Text = "Schema：";
                    Lbl_Tables.Text = "DataTables：";
                    Gbx_Command.Text = "Trans";
                    Btn_View_Table.Text = "Show Table";
                    Btn_Export_Excel.Text = "SQL Export To Excel!!";
                    languageToolStripMenuItem.Text = "Language";
                    chineseSimplifiedToolStripMenuItem.Text = "Chinese(Simplified )";
                    chineseTraditionalToolStripMenuItem.Text = "Chinese(Traditional )";
                    exitToolStripMenuItem.Text = "Exit";
                    englishToolStripMenuItem.Text = "English";
                    Lbl_Search_Column.Text = "The name of the field to search：";
                    Lbl_Search_Condition.Text = "Search condition：";
                    Lbl_Keyword.Text = "Keyword：";
                    Btn_Search.Text = "Search";
                    Gbx_Search.Text = "Search_Option";
                    message1 = "Success Connect";
                    message2 = "Faild Connect";
                    message3 = "Success Converted";
                    this.Text = "MariaDB to Excel V1.0";
                    break;
                case "Chinese(Simplified)":
                    Gbx_Account.Text = "帐户设置";
                    Lbl_IP.Text = "IP位址：";
                    Lbl_User.Text = "SQL 帐戶：";
                    Lbl_Passwd.Text = "密码：";
                    Btn_Connect.Text = "连接";
                    Gbx_DataSelect.Text = "资料库与资料表选择";
                    Lbl_Schema.Text = "资料库：";
                    Lbl_Tables.Text = "资料表";
                    Gbx_Command.Text = "转换区";
                    Btn_View_Table.Text = "检视资料表";
                    Btn_Export_Excel.Text = "汇出至Excel !!";
                    languageToolStripMenuItem.Text = "语言";
                    chineseSimplifiedToolStripMenuItem.Text = "简体中文";
                    chineseTraditionalToolStripMenuItem.Text = "繁体中文";
                    exitToolStripMenuItem.Text = "离开";
                    englishToolStripMenuItem.Text = "英文";
                    Lbl_Search_Column.Text = "欲搜寻之栏位名称：";
                    Lbl_Search_Condition.Text = "搜寻条件：";
                    Lbl_Keyword.Text = "搜寻之关键字：";
                    Btn_Search.Text = "搜寻";
                    Gbx_Search.Text = "搜寻项目设置";
                    message1 = "连接成功";
                    message2 = "连接失败";
                    message3 = "转换成功";
                    this.Text = "MariaDB转Excel转换器Ver1.0";
                    break;
                case "Chinese(Traditional)":
                    Gbx_Account.Text = "帳戶設定";
                    Lbl_IP.Text = "IP位置：";
                    Lbl_User.Text = "SQL 帳號：";
                    Lbl_Passwd.Text = "密碼：";
                    Btn_Connect.Text = "連接";
                    Gbx_DataSelect.Text = "資料庫與資料表選擇";
                    Lbl_Schema.Text = "資料庫：";
                    Lbl_Tables.Text = "資料表";
                    Gbx_Command.Text = "轉換區";
                    Btn_View_Table.Text = "檢視資料表";
                    Btn_Export_Excel.Text = "匯出至Excel!!";
                    languageToolStripMenuItem.Text = "語言";
                    chineseSimplifiedToolStripMenuItem.Text = "簡體中文";
                    chineseTraditionalToolStripMenuItem.Text = "繁體中文";
                    exitToolStripMenuItem.Text = "離開";
                    englishToolStripMenuItem.Text = "英文";
                    Lbl_Search_Column.Text = "欲搜尋之欄位名稱：";
                    Lbl_Search_Condition.Text = "搜尋條件：";
                    Lbl_Keyword.Text = "搜尋之關鍵字：";
                    Btn_Search.Text = "搜尋";
                    Gbx_Search.Text = "搜尋選項設定";
                    message1 = "連接成功";
                    message2 = "連接失敗";
                    message3 = "轉換成功";
                    this.Text = "MariaDB轉Excel轉換器 Ver1.0";
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cmb_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gbx_Command.Enabled = true;
        }

        private void Cmb_Search_Column_DropDown(object sender, EventArgs e)
        {
            Cmb_Search_Column.Items.Clear();
            for(int i = 0; i< dataGridView1.Columns.Count; i ++)
            {
                Cmb_Search_Column.Items.Add(dataGridView1.Columns[i].Name.ToString());
            }
        }

        private void Cmb_Search_Column_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_Column = Cmb_Search_Column.SelectedItem.ToString();
        }

        private void Cmb_Search_Condition_DropDown(object sender, EventArgs e)
        {
            Cmb_Search_Condition.Items.Clear();
            Cmb_Search_Condition.Items.Add("=");
            Cmb_Search_Condition.Items.Add(">");
            Cmb_Search_Condition.Items.Add("<");
            Cmb_Search_Condition.Items.Add("≤");
            Cmb_Search_Condition.Items.Add("≥");
            Cmb_Search_Condition.Items.Add("≠");
            Cmb_Search_Condition.Items.Add("like");
        }

        private void Cmb_Search_Condition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_condition = Cmb_Search_Condition.SelectedItem.ToString();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            int Error_Flag = 0;
            dt1.PrimaryKey = new DataColumn[] { dt1.Columns["ID"] };
            dt2 = dt1.Clone();
            for(int i = 0; i<dt1.Rows.Count; i++)
            {
                switch (Search_condition)
                {
                    case "=":
                        if(dt1.Rows[i][Search_Column].ToString() == Tbx_Keyword.Text)
                        {
                            dt2.ImportRow(dt1.Rows[i]);
                        }
                        else
                        {
                            //dt1.Rows[i].Delete();
                        }
                        break;
                    case ">":
                        try
                        {
                            if (Convert.ToDouble(dt1.Rows[i][Search_Column].ToString()) > Convert.ToDouble(Tbx_Keyword.Text))
                            {
                                dt2.ImportRow(dt1.Rows[i]);
                            }
                            else
                            {
                                //dt1.Rows[i].Delete();
                            }
                            break;
                        }
                        catch
                        {
                            if (Error_Flag == 0)
                            {
                                MessageBox.Show("此判斷標準僅適用於數字資料。");
                            }
                            Error_Flag = 1;
                            break;
                        }
                    case "<":
                        try
                        {
                            if (Convert.ToDouble(dt1.Rows[i][Search_Column].ToString()) < Convert.ToDouble(Tbx_Keyword.Text))
                            {
                                dt2.ImportRow(dt1.Rows[i]);
                            }
                            else
                            {
                                //dt1.Rows[i].Delete();
                            }
                            break;
                        }
                        catch
                        {
                            if (Error_Flag == 0)
                            {
                                MessageBox.Show("此判斷標準僅適用於數字資料。");
                            }
                            Error_Flag = 1;
                            break;
                        }
                    case "≤":
                        try
                        {
                            if (Convert.ToDouble(dt1.Rows[i][Search_Column].ToString()) <= Convert.ToDouble(Tbx_Keyword.Text))
                            {
                                dt2.ImportRow(dt1.Rows[i]);
                            }
                            else
                            {
                                //dt1.Rows[i].Delete();
                            }
                            break;
                        }
                        catch
                        {
                            if (Error_Flag == 0)
                            {
                                MessageBox.Show("此判斷標準僅適用於數字資料。");
                            }
                            Error_Flag = 1;
                            break;
                        }
                    case "≥":
                        try
                        {
                            if (Convert.ToDouble(dt1.Rows[i][Search_Column].ToString()) >= Convert.ToDouble(Tbx_Keyword.Text))
                            {
                                dt2.ImportRow(dt1.Rows[i]);
                            }
                            else
                            {
                                //dt1.Rows[i].Delete();
                            }
                            break;
                        }
                        catch
                        {
                            if (Error_Flag == 0)
                            {
                                MessageBox.Show("此判斷標準僅適用於數字資料。");
                            }
                            Error_Flag = 1;
                            break;
                        }
                    case "≠":
                        if (dt1.Rows[i][Search_Column].ToString() != Tbx_Keyword.Text)
                        {
                            dt2.ImportRow(dt1.Rows[i]);
                        }
                        else
                        {
                            //dt1.Rows[i].Delete();
                        }
                        break;
                    case "like":
                        if((dt1.Rows[i][Search_Column].ToString()).IndexOf(Tbx_Keyword.Text) == 0)
                        {
                            dt2.ImportRow(dt1.Rows[i]);
                        }
                        else
                        {
                            //dt1.Rows[i].Delete();
                        }
                        break;
                }
            }
            Have_be_searching = 1;//被搜尋過了
            dt_Cache.Clear();
            //分筆數
            int page_count = dt2.Rows.Count / B_Page_Limit;
            if (dt2.Rows.Count % B_Page_Limit != 0)
            {
                page_count += 1;
            }
            Cmb_Page_Count.Items.Clear();
            for (int i = 1; i <= page_count; i++)
            {
                Cmb_Page_Count.Items.Add(i.ToString());
            }
            //先顯示第一頁
            dt_Cache = dt2.Clone();//先複製他的格式(不是資料)
            for (int i = 0; i < B_Page_Limit; i++)
            {
                try
                {
                    dt_Cache.ImportRow(dt2.Rows[i]);
                }
                catch
                {

                }
            }
            Cmb_Page_Count.SelectedIndex = 0;
            dataGridView1.DataSource = dt_Cache;
            dataGridView1.MakeDoubleBuffered(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Language_Set();
        }

        private void Cmb_Page_Count_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Have_be_searching == 0)
            {
                Page_Data_Display_DT1();
            }
            else
            {
                Page_Data_Display_DT2();
            }
        }

        private void Btn_Next_Page_Click(object sender, EventArgs e)
        {
            Cmb_Page_Count.SelectedIndex += 1;
            if (Have_be_searching == 0)
            {
                Page_Data_Display_DT1();
            }
            else
            {
                Page_Data_Display_DT2();
            }
        }

        private void Btn_Previous_Page_Click(object sender, EventArgs e)
        {
            Cmb_Page_Count.SelectedIndex -= 1;
            if (Have_be_searching == 0)
            {
                Page_Data_Display_DT1();
            }
            else
            {
                Page_Data_Display_DT2();
            }
        }

        private void Btn_Head_Page_Click(object sender, EventArgs e)
        {
            Cmb_Page_Count.SelectedIndex = 0;//回到第一頁
            if (Have_be_searching == 0)
            {
                Page_Data_Display_DT1();
            }
            else
            {
                Page_Data_Display_DT2();
            }
        }

        private void Btn_End_Page_Click(object sender, EventArgs e)
        {
            Cmb_Page_Count.SelectedIndex = Cmb_Page_Count.Items.Count - 1;//他是以0為1
            if (Have_be_searching == 0)
            {
                Page_Data_Display_DT1();
            }
            else
            {
                Page_Data_Display_DT2();
            }
        }
    }
    public static class ControlExtentions
    {
        public static void MakeDoubleBuffered(this Control control, bool setting)
        {
            Type controlType = control.GetType();
            PropertyInfo pi = controlType.GetProperty("DoubleBuffered",
            BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(control, setting, null);
        }
    }//防止DataGridView更新或滾輪滑動時閃爍
}
