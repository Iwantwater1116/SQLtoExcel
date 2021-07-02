using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace SQLtoExcel
{
    class MariaDB_Connect_Librarys
    {

        MySqlConnection DBconn = new MySqlConnection();//Create new MariaDB Connection element.

        public int MariaDB_Connect(string address, string database_name, string UserID, string passwd, int needdatabase_data)
        {
            try
            {
                string ConnectStr = "";
                if (needdatabase_data == 0)
                {
                    ConnectStr =  @"Data Source=" + address + "; User ID = " + UserID + "; password=" + passwd + ";SslMode=None;charset=utf8";
                }
                else
                {
                    ConnectStr = @"Data Source=" + address + "; Database=" + database_name + "; User ID = " + UserID + "; password=" + passwd + ";SslMode=None;charset=utf8";
                }
                DBconn = new MySqlConnection(ConnectStr);
                DBconn.Close();
                DBconn.Open();
                return 0;
            }
            catch
            {
                return 1;
            }
        }//Connect to MariaDB.

        public void MariaDB_Close_Open(string State)
        {
            switch(State)
            {
                case "Open":
                    DBconn.Open();
                    break;
                case "Close":
                    DBconn.Close();
                    break;
            }
        }//Open and close MariaDB database.

        public void Search_DataTable(List<string> Tablelist, String DataBaseName)
        {
            string query = "show tables from " + DataBaseName;
            MySqlCommand cmd = new MySqlCommand(query, DBconn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Tablelist.Add(reader.GetString(0));
            }
            DBconn.Close();
            System.Threading.Thread.Sleep(100);
            DBconn.Open();
        }//Search datatable's name from database.

        public void Search_DataBases(List<string> Tablelist)
        {
            string query = "show databases";
            MySqlCommand cmd = new MySqlCommand(query, DBconn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Tablelist.Add(reader.GetString(0));
            }
            DBconn.Close();
            System.Threading.Thread.Sleep(100);
            DBconn.Open();
        }//Search database's name 

        public void SQL_To_DataSet( DataTable dt1,string DataTableName)
        {
            string sql_command = @"select* from `" + DataTableName + "`";
            MySqlDataAdapter sa = new MySqlDataAdapter();
            sa = new MySqlDataAdapter(sql_command, DBconn);
            sa.Fill(dt1);
        }//MariaDB convert to datatable in ADO.NET.

        public void sqlcommand(string command, ref List<string> name)
        {
            MySqlCommand sqlcmd = new MySqlCommand(command, DBconn);

            MySqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                if(reader[0].ToString() != null)
                {
                    name.Add(reader[0].ToString());
                }

            }
        }//Send SQL command and receive information from MariaDB database.

        public void sqlcommand_no_receive(string command)
        {
            MySqlCommand sqlcmd = new MySqlCommand(command, DBconn);
        }//Send SQL command but no receive

        public void SQLData_To_Excel(string SQLTable_Name, ProgressBar pb)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            string sql_command = @"select* from `" + SQLTable_Name + "`";
            MySqlDataAdapter sa = new MySqlDataAdapter(sql_command, DBconn);
            sa.Fill(dt);
            SaveFileDialog filesave = new SaveFileDialog();
            filesave.Title = "Export Excel";
            filesave.InitialDirectory = ".\\";
            filesave.Filter = "Excel Workbook (*.xlsx*)|*.xlsx*";
            filesave.DefaultExt = "xlsx";
            if (filesave.ShowDialog() == DialogResult.OK)
            {
                string filepath = filesave.FileName;
                string filename = Path.GetFileName(filesave.FileName);
                F_SQLData_To_Excel(dt,SQLTable_Name,filepath,filename, pb);
                return;
            }

        }//MariaDB datatable convert to Excel and save as another file.

        public void DataGirdView_To_Excel(DataTable dt, ProgressBar pb)
        {
            SaveFileDialog filesave = new SaveFileDialog();
            filesave.Title = "Export Excel";
            filesave.InitialDirectory = ".\\";
            filesave.Filter = "Excel Workbook (*.xlsx*)|*.xlsx*";
            filesave.DefaultExt = "xlsx";
            if (filesave.ShowDialog() == DialogResult.OK)
            {
                string filepath = filesave.FileName;
                string filename = Path.GetFileName(filesave.FileName);
                F_SQLData_To_Excel(dt, "new workbook", filepath, filename, pb);
                return;
            }

        }//DataGirdView datatable convert to Excel and save as another file.

        private void F_SQLData_To_Excel(DataTable ddt, string Tablename,string SaveFilePath,string SaveFileName, ProgressBar pb1)
        {
            string FileStr = SaveFilePath;
            Excel.Application Excel_APP1 = new Excel.Application();
            Excel.Workbook Excel_WB1 = Excel_APP1.Workbooks.Add();
            Excel.Worksheet Excel_WS1 = Excel_WB1.Worksheets.Add();
            Excel_WS1.Name = Tablename.ToUpper();
            pb1.Maximum = ddt.Rows.Count;
            //=====================Start Translate====================//
            for(int i = 1; i<= ddt.Columns.Count; i++)
            {
                Excel_APP1.Cells[1, i] = ddt.Columns[i-1].ColumnName;
                Application.DoEvents();
            }
            for(int i = 0; i< ddt.Rows.Count; i++)
            {
                for(int j = 1; j<= ddt.Columns.Count; j++)
                {
                    Excel_APP1.Cells[i + 2, j] = ddt.Rows[i][j - 1];
                    Application.DoEvents();
                }
                pb1.Value = pb1.Value + 1;
                Application.DoEvents();
            }
            Excel_WS1.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            Excel_WS1.Cells.EntireRow.AutoFit();
            Excel_WS1.Cells.EntireColumn.AutoFit();
            Excel_WB1.SaveAs(FileStr);
            Excel_WS1 = null;
            Excel_WB1.Close();
            Excel_WB1 = null;
            Excel_APP1.Quit();
            Excel_APP1 = null;
        }//ADO.NET Datatable convert to Excel.
    }
}
