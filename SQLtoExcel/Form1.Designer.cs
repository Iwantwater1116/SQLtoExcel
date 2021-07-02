namespace SQLtoExcel
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Gbx_Account = new System.Windows.Forms.GroupBox();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Tbx_Passwd = new System.Windows.Forms.TextBox();
            this.Tbx_User = new System.Windows.Forms.TextBox();
            this.Tbx_IP = new System.Windows.Forms.TextBox();
            this.Lbl_Passwd = new System.Windows.Forms.Label();
            this.Lbl_User = new System.Windows.Forms.Label();
            this.Lbl_IP = new System.Windows.Forms.Label();
            this.Gbx_DataSelect = new System.Windows.Forms.GroupBox();
            this.Cmb_Tables = new System.Windows.Forms.ComboBox();
            this.Lbl_Tables = new System.Windows.Forms.Label();
            this.Cmb_schema = new System.Windows.Forms.ComboBox();
            this.Lbl_Schema = new System.Windows.Forms.Label();
            this.Gbx_Command = new System.Windows.Forms.GroupBox();
            this.Btn_Export_Excel = new System.Windows.Forms.Button();
            this.Btn_View_Table = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseSimplifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseTraditionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Gbx_Search = new System.Windows.Forms.GroupBox();
            this.Tbx_Keyword = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Cmb_Search_Condition = new System.Windows.Forms.ComboBox();
            this.Lbl_Keyword = new System.Windows.Forms.Label();
            this.Lbl_Search_Condition = new System.Windows.Forms.Label();
            this.Cmb_Search_Column = new System.Windows.Forms.ComboBox();
            this.Lbl_Search_Column = new System.Windows.Forms.Label();
            this.Btn_Previous_Page = new System.Windows.Forms.Button();
            this.Btn_Next_Page = new System.Windows.Forms.Button();
            this.Btn_Head_Page = new System.Windows.Forms.Button();
            this.Btn_End_Page = new System.Windows.Forms.Button();
            this.Cmb_Page_Count = new System.Windows.Forms.ComboBox();
            this.Gbx_Account.SuspendLayout();
            this.Gbx_DataSelect.SuspendLayout();
            this.Gbx_Command.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Gbx_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbx_Account
            // 
            this.Gbx_Account.Controls.Add(this.Btn_Connect);
            this.Gbx_Account.Controls.Add(this.Tbx_Passwd);
            this.Gbx_Account.Controls.Add(this.Tbx_User);
            this.Gbx_Account.Controls.Add(this.Tbx_IP);
            this.Gbx_Account.Controls.Add(this.Lbl_Passwd);
            this.Gbx_Account.Controls.Add(this.Lbl_User);
            this.Gbx_Account.Controls.Add(this.Lbl_IP);
            this.Gbx_Account.Location = new System.Drawing.Point(12, 27);
            this.Gbx_Account.Name = "Gbx_Account";
            this.Gbx_Account.Size = new System.Drawing.Size(259, 167);
            this.Gbx_Account.TabIndex = 0;
            this.Gbx_Account.TabStop = false;
            this.Gbx_Account.Text = "MariaDB Account Information";
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(154, 119);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(95, 38);
            this.Btn_Connect.TabIndex = 4;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Tbx_Passwd
            // 
            this.Tbx_Passwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tbx_Passwd.Location = new System.Drawing.Point(112, 81);
            this.Tbx_Passwd.Name = "Tbx_Passwd";
            this.Tbx_Passwd.PasswordChar = '●';
            this.Tbx_Passwd.Size = new System.Drawing.Size(100, 22);
            this.Tbx_Passwd.TabIndex = 3;
            // 
            // Tbx_User
            // 
            this.Tbx_User.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tbx_User.Location = new System.Drawing.Point(112, 51);
            this.Tbx_User.Name = "Tbx_User";
            this.Tbx_User.Size = new System.Drawing.Size(100, 22);
            this.Tbx_User.TabIndex = 2;
            // 
            // Tbx_IP
            // 
            this.Tbx_IP.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tbx_IP.Location = new System.Drawing.Point(112, 21);
            this.Tbx_IP.Name = "Tbx_IP";
            this.Tbx_IP.Size = new System.Drawing.Size(100, 22);
            this.Tbx_IP.TabIndex = 1;
            // 
            // Lbl_Passwd
            // 
            this.Lbl_Passwd.AutoSize = true;
            this.Lbl_Passwd.Location = new System.Drawing.Point(15, 86);
            this.Lbl_Passwd.Name = "Lbl_Passwd";
            this.Lbl_Passwd.Size = new System.Drawing.Size(60, 12);
            this.Lbl_Passwd.TabIndex = 0;
            this.Lbl_Passwd.Text = "Password：";
            // 
            // Lbl_User
            // 
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.Location = new System.Drawing.Point(15, 56);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(68, 12);
            this.Lbl_User.TabIndex = 0;
            this.Lbl_User.Text = "User Name：";
            // 
            // Lbl_IP
            // 
            this.Lbl_IP.AutoSize = true;
            this.Lbl_IP.Location = new System.Drawing.Point(15, 26);
            this.Lbl_IP.Name = "Lbl_IP";
            this.Lbl_IP.Size = new System.Drawing.Size(91, 12);
            this.Lbl_IP.TabIndex = 0;
            this.Lbl_IP.Text = "SQL IP Address：";
            // 
            // Gbx_DataSelect
            // 
            this.Gbx_DataSelect.Controls.Add(this.Cmb_Tables);
            this.Gbx_DataSelect.Controls.Add(this.Lbl_Tables);
            this.Gbx_DataSelect.Controls.Add(this.Cmb_schema);
            this.Gbx_DataSelect.Controls.Add(this.Lbl_Schema);
            this.Gbx_DataSelect.Enabled = false;
            this.Gbx_DataSelect.Location = new System.Drawing.Point(294, 26);
            this.Gbx_DataSelect.Name = "Gbx_DataSelect";
            this.Gbx_DataSelect.Size = new System.Drawing.Size(215, 167);
            this.Gbx_DataSelect.TabIndex = 1;
            this.Gbx_DataSelect.TabStop = false;
            this.Gbx_DataSelect.Text = "Schema andTable Select";
            // 
            // Cmb_Tables
            // 
            this.Cmb_Tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Tables.FormattingEnabled = true;
            this.Cmb_Tables.Location = new System.Drawing.Point(6, 106);
            this.Cmb_Tables.Name = "Cmb_Tables";
            this.Cmb_Tables.Size = new System.Drawing.Size(203, 20);
            this.Cmb_Tables.TabIndex = 6;
            this.Cmb_Tables.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.Cmb_Tables.SelectedIndexChanged += new System.EventHandler(this.Cmb_Tables_SelectedIndexChanged);
            // 
            // Lbl_Tables
            // 
            this.Lbl_Tables.AutoSize = true;
            this.Lbl_Tables.Location = new System.Drawing.Point(6, 91);
            this.Lbl_Tables.Name = "Lbl_Tables";
            this.Lbl_Tables.Size = new System.Drawing.Size(68, 12);
            this.Lbl_Tables.TabIndex = 0;
            this.Lbl_Tables.Text = "DataTables：";
            // 
            // Cmb_schema
            // 
            this.Cmb_schema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_schema.FormattingEnabled = true;
            this.Cmb_schema.Location = new System.Drawing.Point(6, 36);
            this.Cmb_schema.Name = "Cmb_schema";
            this.Cmb_schema.Size = new System.Drawing.Size(203, 20);
            this.Cmb_schema.TabIndex = 5;
            this.Cmb_schema.DropDown += new System.EventHandler(this.Cmb_schema_DropDown);
            this.Cmb_schema.SelectedIndexChanged += new System.EventHandler(this.Cmb_schema_SelectedIndexChanged);
            // 
            // Lbl_Schema
            // 
            this.Lbl_Schema.AutoSize = true;
            this.Lbl_Schema.Location = new System.Drawing.Point(6, 21);
            this.Lbl_Schema.Name = "Lbl_Schema";
            this.Lbl_Schema.Size = new System.Drawing.Size(53, 12);
            this.Lbl_Schema.TabIndex = 0;
            this.Lbl_Schema.Text = "Schema：";
            // 
            // Gbx_Command
            // 
            this.Gbx_Command.Controls.Add(this.Btn_Export_Excel);
            this.Gbx_Command.Controls.Add(this.Btn_View_Table);
            this.Gbx_Command.Enabled = false;
            this.Gbx_Command.Location = new System.Drawing.Point(524, 26);
            this.Gbx_Command.Name = "Gbx_Command";
            this.Gbx_Command.Size = new System.Drawing.Size(262, 167);
            this.Gbx_Command.TabIndex = 2;
            this.Gbx_Command.TabStop = false;
            this.Gbx_Command.Text = "Trans";
            // 
            // Btn_Export_Excel
            // 
            this.Btn_Export_Excel.Location = new System.Drawing.Point(44, 106);
            this.Btn_Export_Excel.Name = "Btn_Export_Excel";
            this.Btn_Export_Excel.Size = new System.Drawing.Size(182, 47);
            this.Btn_Export_Excel.TabIndex = 8;
            this.Btn_Export_Excel.Text = "SQL Export To Excel!!";
            this.Btn_Export_Excel.UseVisualStyleBackColor = true;
            this.Btn_Export_Excel.Click += new System.EventHandler(this.Btn_Export_Excel_Click);
            // 
            // Btn_View_Table
            // 
            this.Btn_View_Table.Location = new System.Drawing.Point(44, 26);
            this.Btn_View_Table.Name = "Btn_View_Table";
            this.Btn_View_Table.Size = new System.Drawing.Size(182, 47);
            this.Btn_View_Table.TabIndex = 7;
            this.Btn_View_Table.Text = "Show Table";
            this.Btn_View_Table.UseVisualStyleBackColor = true;
            this.Btn_View_Table.Click += new System.EventHandler(this.Btn_View_Table_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 365);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chineseSimplifiedToolStripMenuItem,
            this.chineseTraditionalToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // chineseSimplifiedToolStripMenuItem
            // 
            this.chineseSimplifiedToolStripMenuItem.Name = "chineseSimplifiedToolStripMenuItem";
            this.chineseSimplifiedToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.chineseSimplifiedToolStripMenuItem.Text = "Chinese(Simplified )";
            this.chineseSimplifiedToolStripMenuItem.Click += new System.EventHandler(this.chineseSimplifiedToolStripMenuItem_Click);
            // 
            // chineseTraditionalToolStripMenuItem
            // 
            this.chineseTraditionalToolStripMenuItem.Name = "chineseTraditionalToolStripMenuItem";
            this.chineseTraditionalToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.chineseTraditionalToolStripMenuItem.Text = "Chinese(Traditional )";
            this.chineseTraditionalToolStripMenuItem.Click += new System.EventHandler(this.chineseTraditionalToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(7, 571);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(278, 31);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // Gbx_Search
            // 
            this.Gbx_Search.Controls.Add(this.Tbx_Keyword);
            this.Gbx_Search.Controls.Add(this.Btn_Search);
            this.Gbx_Search.Controls.Add(this.Cmb_Search_Condition);
            this.Gbx_Search.Controls.Add(this.Lbl_Keyword);
            this.Gbx_Search.Controls.Add(this.Lbl_Search_Condition);
            this.Gbx_Search.Controls.Add(this.Cmb_Search_Column);
            this.Gbx_Search.Controls.Add(this.Lbl_Search_Column);
            this.Gbx_Search.Enabled = false;
            this.Gbx_Search.Location = new System.Drawing.Point(792, 27);
            this.Gbx_Search.Name = "Gbx_Search";
            this.Gbx_Search.Size = new System.Drawing.Size(367, 167);
            this.Gbx_Search.TabIndex = 1;
            this.Gbx_Search.TabStop = false;
            this.Gbx_Search.Text = "Search Option";
            // 
            // Tbx_Keyword
            // 
            this.Tbx_Keyword.Location = new System.Drawing.Point(6, 129);
            this.Tbx_Keyword.Name = "Tbx_Keyword";
            this.Tbx_Keyword.Size = new System.Drawing.Size(202, 22);
            this.Tbx_Keyword.TabIndex = 8;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(232, 39);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(119, 115);
            this.Btn_Search.TabIndex = 7;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Cmb_Search_Condition
            // 
            this.Cmb_Search_Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Search_Condition.FormattingEnabled = true;
            this.Cmb_Search_Condition.Location = new System.Drawing.Point(6, 83);
            this.Cmb_Search_Condition.Name = "Cmb_Search_Condition";
            this.Cmb_Search_Condition.Size = new System.Drawing.Size(203, 20);
            this.Cmb_Search_Condition.TabIndex = 6;
            this.Cmb_Search_Condition.DropDown += new System.EventHandler(this.Cmb_Search_Condition_DropDown);
            this.Cmb_Search_Condition.SelectedIndexChanged += new System.EventHandler(this.Cmb_Search_Condition_SelectedIndexChanged);
            // 
            // Lbl_Keyword
            // 
            this.Lbl_Keyword.AutoSize = true;
            this.Lbl_Keyword.Location = new System.Drawing.Point(6, 109);
            this.Lbl_Keyword.Name = "Lbl_Keyword";
            this.Lbl_Keyword.Size = new System.Drawing.Size(60, 12);
            this.Lbl_Keyword.TabIndex = 0;
            this.Lbl_Keyword.Text = "Keyword：";
            // 
            // Lbl_Search_Condition
            // 
            this.Lbl_Search_Condition.AutoSize = true;
            this.Lbl_Search_Condition.Location = new System.Drawing.Point(6, 65);
            this.Lbl_Search_Condition.Name = "Lbl_Search_Condition";
            this.Lbl_Search_Condition.Size = new System.Drawing.Size(95, 12);
            this.Lbl_Search_Condition.TabIndex = 0;
            this.Lbl_Search_Condition.Text = "Search condition：";
            // 
            // Cmb_Search_Column
            // 
            this.Cmb_Search_Column.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Search_Column.FormattingEnabled = true;
            this.Cmb_Search_Column.Location = new System.Drawing.Point(6, 39);
            this.Cmb_Search_Column.Name = "Cmb_Search_Column";
            this.Cmb_Search_Column.Size = new System.Drawing.Size(203, 20);
            this.Cmb_Search_Column.TabIndex = 5;
            this.Cmb_Search_Column.DropDown += new System.EventHandler(this.Cmb_Search_Column_DropDown);
            this.Cmb_Search_Column.SelectedIndexChanged += new System.EventHandler(this.Cmb_Search_Column_SelectedIndexChanged);
            // 
            // Lbl_Search_Column
            // 
            this.Lbl_Search_Column.AutoSize = true;
            this.Lbl_Search_Column.Location = new System.Drawing.Point(6, 21);
            this.Lbl_Search_Column.Name = "Lbl_Search_Column";
            this.Lbl_Search_Column.Size = new System.Drawing.Size(161, 12);
            this.Lbl_Search_Column.TabIndex = 0;
            this.Lbl_Search_Column.Text = "The name of the field to search：";
            // 
            // Btn_Previous_Page
            // 
            this.Btn_Previous_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Previous_Page.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Previous_Page.Location = new System.Drawing.Point(814, 572);
            this.Btn_Previous_Page.Name = "Btn_Previous_Page";
            this.Btn_Previous_Page.Size = new System.Drawing.Size(63, 30);
            this.Btn_Previous_Page.TabIndex = 6;
            this.Btn_Previous_Page.Text = "<";
            this.Btn_Previous_Page.UseVisualStyleBackColor = true;
            this.Btn_Previous_Page.Click += new System.EventHandler(this.Btn_Previous_Page_Click);
            // 
            // Btn_Next_Page
            // 
            this.Btn_Next_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Next_Page.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Next_Page.Location = new System.Drawing.Point(1011, 571);
            this.Btn_Next_Page.Name = "Btn_Next_Page";
            this.Btn_Next_Page.Size = new System.Drawing.Size(63, 30);
            this.Btn_Next_Page.TabIndex = 6;
            this.Btn_Next_Page.Text = ">";
            this.Btn_Next_Page.UseVisualStyleBackColor = true;
            this.Btn_Next_Page.Click += new System.EventHandler(this.Btn_Next_Page_Click);
            // 
            // Btn_Head_Page
            // 
            this.Btn_Head_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Head_Page.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Head_Page.Location = new System.Drawing.Point(745, 571);
            this.Btn_Head_Page.Name = "Btn_Head_Page";
            this.Btn_Head_Page.Size = new System.Drawing.Size(63, 30);
            this.Btn_Head_Page.TabIndex = 6;
            this.Btn_Head_Page.Text = "<<";
            this.Btn_Head_Page.UseVisualStyleBackColor = true;
            this.Btn_Head_Page.Click += new System.EventHandler(this.Btn_Head_Page_Click);
            // 
            // Btn_End_Page
            // 
            this.Btn_End_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_End_Page.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_End_Page.Location = new System.Drawing.Point(1080, 571);
            this.Btn_End_Page.Name = "Btn_End_Page";
            this.Btn_End_Page.Size = new System.Drawing.Size(63, 30);
            this.Btn_End_Page.TabIndex = 6;
            this.Btn_End_Page.Text = ">>";
            this.Btn_End_Page.UseVisualStyleBackColor = true;
            this.Btn_End_Page.Click += new System.EventHandler(this.Btn_End_Page_Click);
            // 
            // Cmb_Page_Count
            // 
            this.Cmb_Page_Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Page_Count.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cmb_Page_Count.FormattingEnabled = true;
            this.Cmb_Page_Count.Location = new System.Drawing.Point(890, 572);
            this.Cmb_Page_Count.Name = "Cmb_Page_Count";
            this.Cmb_Page_Count.Size = new System.Drawing.Size(110, 29);
            this.Cmb_Page_Count.TabIndex = 7;
            this.Cmb_Page_Count.SelectedIndexChanged += new System.EventHandler(this.Cmb_Page_Count_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 606);
            this.Controls.Add(this.Cmb_Page_Count);
            this.Controls.Add(this.Btn_End_Page);
            this.Controls.Add(this.Btn_Next_Page);
            this.Controls.Add(this.Btn_Head_Page);
            this.Controls.Add(this.Btn_Previous_Page);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Gbx_Command);
            this.Controls.Add(this.Gbx_Search);
            this.Controls.Add(this.Gbx_DataSelect);
            this.Controls.Add(this.Gbx_Account);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MariaDB to Excel V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Gbx_Account.ResumeLayout(false);
            this.Gbx_Account.PerformLayout();
            this.Gbx_DataSelect.ResumeLayout(false);
            this.Gbx_DataSelect.PerformLayout();
            this.Gbx_Command.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Gbx_Search.ResumeLayout(false);
            this.Gbx_Search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbx_Account;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.TextBox Tbx_Passwd;
        private System.Windows.Forms.TextBox Tbx_User;
        private System.Windows.Forms.TextBox Tbx_IP;
        private System.Windows.Forms.Label Lbl_Passwd;
        private System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.Label Lbl_IP;
        private System.Windows.Forms.GroupBox Gbx_DataSelect;
        private System.Windows.Forms.ComboBox Cmb_schema;
        private System.Windows.Forms.Label Lbl_Schema;
        private System.Windows.Forms.ComboBox Cmb_Tables;
        private System.Windows.Forms.Label Lbl_Tables;
        private System.Windows.Forms.GroupBox Gbx_Command;
        private System.Windows.Forms.Button Btn_Export_Excel;
        private System.Windows.Forms.Button Btn_View_Table;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chineseSimplifiedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chineseTraditionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox Gbx_Search;
        private System.Windows.Forms.TextBox Tbx_Keyword;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.ComboBox Cmb_Search_Condition;
        private System.Windows.Forms.Label Lbl_Keyword;
        private System.Windows.Forms.Label Lbl_Search_Condition;
        private System.Windows.Forms.ComboBox Cmb_Search_Column;
        private System.Windows.Forms.Label Lbl_Search_Column;
        private System.Windows.Forms.Button Btn_Previous_Page;
        private System.Windows.Forms.Button Btn_Next_Page;
        private System.Windows.Forms.Button Btn_Head_Page;
        private System.Windows.Forms.Button Btn_End_Page;
        private System.Windows.Forms.ComboBox Cmb_Page_Count;
    }
}

