using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLtoExcel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int option = 0;
        public int Have_Search_Flag = 0;//沒有
        private void F_language_display()
        {
            string language = Form1.Language;
            switch(language)
            {
                case "English":
                    label1.Text = "Please select the type of table you want to export：";
                    button1.Text = "Filtered data";
                    button2.Text = "Entire table";
                    button3.Text = "Data on this page";
                    break;
                case "Chinese(Traditional)":
                    label1.Text = "請選擇您要的輸出的資料類型：";
                    button1.Text = "過濾後的資料";
                    button2.Text = "整份資料表";
                    button3.Text = "本資料頁";
                    break;
                case "Chinese(Simplified)":
                    label1.Text = "请选择您要汇出的数据型别：";
                    button1.Text = "过滤后的数据";
                    button2.Text = "整份列表";
                    button3.Text = "本数据页";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            option = 0;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            option = 1;
            this.Close();
        }

        public int return_asnwer()
        {
            return option;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            F_language_display();
            if(Have_Search_Flag == 0)
            {
                button1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            option = 2;
            this.Close();
        }
    }
}
