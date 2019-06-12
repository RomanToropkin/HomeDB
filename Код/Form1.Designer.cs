namespace Cursach.View
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPersonFilter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tb_resCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_flatNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnServiceClear = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.tbServiceCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbServiceName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewHouse = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHouseClear = new System.Windows.Forms.Button();
            this.btnHouseFilter = new System.Windows.Forms.Button();
            this.btnHouseAdd = new System.Windows.Forms.Button();
            this.tbHouseCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHouseCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbHouseName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveLock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveJson = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveJsonFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHouse)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 437);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Жильцы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(690, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridViewPerson_MouseClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.btnPersonFilter, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.tb_resCount, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_flatNum, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_fullname, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(696, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(174, 405);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.Location = new System.Drawing.Point(9, 373);
            this.btnClear.Margin = new System.Windows.Forms.Padding(9, 15, 9, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Сбросить фильтры";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnPersonFilter
            // 
            this.btnPersonFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonFilter.Location = new System.Drawing.Point(9, 324);
            this.btnPersonFilter.Margin = new System.Windows.Forms.Padding(9, 15, 9, 0);
            this.btnPersonFilter.Name = "btnPersonFilter";
            this.btnPersonFilter.Size = new System.Drawing.Size(156, 23);
            this.btnPersonFilter.TabIndex = 9;
            this.btnPersonFilter.Text = "Фильтры";
            this.btnPersonFilter.UseVisualStyleBackColor = false;
            this.btnPersonFilter.Click += new System.EventHandler(this.BtnPersonFilter_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(9, 280);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить запись";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnPersonAdd_Click);
            // 
            // tb_resCount
            // 
            this.tb_resCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_resCount.Location = new System.Drawing.Point(9, 209);
            this.tb_resCount.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.tb_resCount.Name = "tb_resCount";
            this.tb_resCount.Size = new System.Drawing.Size(156, 20);
            this.tb_resCount.TabIndex = 6;
            this.tb_resCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyNumberPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Кол-во проживающих";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_flatNum
            // 
            this.tb_flatNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_flatNum.Location = new System.Drawing.Point(9, 129);
            this.tb_flatNum.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.tb_flatNum.Name = "tb_flatNum";
            this.tb_flatNum.Size = new System.Drawing.Size(156, 20);
            this.tb_flatNum.TabIndex = 4;
            this.tb_flatNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyNumberPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер квартиры";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ф.И.О";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_fullname
            // 
            this.tb_fullname.BackColor = System.Drawing.SystemColors.Window;
            this.tb_fullname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_fullname.Location = new System.Drawing.Point(9, 69);
            this.tb_fullname.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(156, 20);
            this.tb_fullname.TabIndex = 2;
            this.tb_fullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(9, 243);
            this.button1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить счёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnPersonReceiptAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расходы на обслуживание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewService, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(870, 405);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToResizeColumns = false;
            this.dataGridViewService.AllowUserToResizeRows = false;
            this.dataGridViewService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewService.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewService.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Amazing Grotesk", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewService.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewService.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewService.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewService.MultiSelect = false;
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewService.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewService.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewService.Size = new System.Drawing.Size(690, 399);
            this.dataGridViewService.TabIndex = 0;
            this.dataGridViewService.SelectionChanged += new System.EventHandler(this.DataGridViewService_SelectionChanged);
            this.dataGridViewService.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridViewService_MouseClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnServiceClear, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.btnFilters, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.btnServiceAdd, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.tbServiceCost, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbServiceName, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(696, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(174, 405);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnServiceClear
            // 
            this.btnServiceClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiceClear.Location = new System.Drawing.Point(9, 252);
            this.btnServiceClear.Margin = new System.Windows.Forms.Padding(9, 15, 9, 0);
            this.btnServiceClear.Name = "btnServiceClear";
            this.btnServiceClear.Size = new System.Drawing.Size(156, 23);
            this.btnServiceClear.TabIndex = 10;
            this.btnServiceClear.Text = "Сбросить фильтры";
            this.btnServiceClear.UseVisualStyleBackColor = true;
            this.btnServiceClear.Click += new System.EventHandler(this.BtnServiceClear_Click);
            // 
            // btnFilters
            // 
            this.btnFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilters.Location = new System.Drawing.Point(9, 203);
            this.btnFilters.Margin = new System.Windows.Forms.Padding(9, 15, 9, 0);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(156, 23);
            this.btnFilters.TabIndex = 9;
            this.btnFilters.Text = "Фильтры";
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.BtnServiceFilters_Click);
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiceAdd.Location = new System.Drawing.Point(9, 159);
            this.btnServiceAdd.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(156, 23);
            this.btnServiceAdd.TabIndex = 8;
            this.btnServiceAdd.Text = "Добавить запись";
            this.btnServiceAdd.UseVisualStyleBackColor = true;
            this.btnServiceAdd.Click += new System.EventHandler(this.BtnServiceAdd_Click);
            // 
            // tbServiceCost
            // 
            this.tbServiceCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbServiceCost.Location = new System.Drawing.Point(9, 129);
            this.tbServiceCost.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.tbServiceCost.Name = "tbServiceCost";
            this.tbServiceCost.Size = new System.Drawing.Size(156, 20);
            this.tbServiceCost.TabIndex = 4;
            this.tbServiceCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyDoublePress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Стоимость";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Наименование";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Добавить";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbServiceName
            // 
            this.tbServiceName.BackColor = System.Drawing.SystemColors.Window;
            this.tbServiceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbServiceName.Location = new System.Drawing.Point(9, 69);
            this.tbServiceName.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.tbServiceName.Name = "tbServiceName";
            this.tbServiceName.Size = new System.Drawing.Size(156, 20);
            this.tbServiceName.TabIndex = 2;
            this.tbServiceName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(876, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Хоз. расходы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.dataGridViewHouse, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(870, 405);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // dataGridViewHouse
            // 
            this.dataGridViewHouse.AllowDrop = true;
            this.dataGridViewHouse.AllowUserToResizeColumns = false;
            this.dataGridViewHouse.AllowUserToResizeRows = false;
            this.dataGridViewHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewHouse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewHouse.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewHouse.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Amazing Grotesk", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHouse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewHouse.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewHouse.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewHouse.MultiSelect = false;
            this.dataGridViewHouse.Name = "dataGridViewHouse";
            this.dataGridViewHouse.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHouse.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewHouse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewHouse.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewHouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewHouse.Size = new System.Drawing.Size(690, 399);
            this.dataGridViewHouse.TabIndex = 0;
            this.dataGridViewHouse.SelectionChanged += new System.EventHandler(this.DataGridViewHouse_SelectionChanged);
            this.dataGridViewHouse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridViewHouse_MouseClick);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.btnHouseClear, 0, 9);
            this.tableLayoutPanel6.Controls.Add(this.btnHouseFilter, 0, 8);
            this.tableLayoutPanel6.Controls.Add(this.btnHouseAdd, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.tbHouseCost, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.tbHouseCount, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbHouseName, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(696, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 10;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(174, 405);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // btnHouseClear
            // 
            this.btnHouseClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHouseClear.Location = new System.Drawing.Point(9, 336);
            this.btnHouseClear.Margin = new System.Windows.Forms.Padding(9, 15, 9, 0);
            this.btnHouseClear.Name = "btnHouseClear";
            this.btnHouseClear.Size = new System.Drawing.Size(156, 23);
            this.btnHouseClear.TabIndex = 10;
            this.btnHouseClear.Text = "Сбросить фильтры";
            this.btnHouseClear.UseVisualStyleBackColor = true;
            this.btnHouseClear.Click += new System.EventHandler(this.BtnHouseClear_Click);
            // 
            // btnHouseFilter
            // 
            this.btnHouseFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHouseFilter.Location = new System.Drawing.Point(9, 287);
            this.btnHouseFilter.Margin = new System.Windows.Forms.Padding(9, 15, 9, 0);
            this.btnHouseFilter.Name = "btnHouseFilter";
            this.btnHouseFilter.Size = new System.Drawing.Size(156, 23);
            this.btnHouseFilter.TabIndex = 9;
            this.btnHouseFilter.Text = "Фильтры";
            this.btnHouseFilter.UseVisualStyleBackColor = true;
            this.btnHouseFilter.Click += new System.EventHandler(this.BtnHouseFilter_Click);
            // 
            // btnHouseAdd
            // 
            this.btnHouseAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHouseAdd.Location = new System.Drawing.Point(9, 235);
            this.btnHouseAdd.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.btnHouseAdd.Name = "btnHouseAdd";
            this.btnHouseAdd.Size = new System.Drawing.Size(156, 23);
            this.btnHouseAdd.TabIndex = 8;
            this.btnHouseAdd.Text = "Добавить запись";
            this.btnHouseAdd.UseVisualStyleBackColor = true;
            this.btnHouseAdd.Click += new System.EventHandler(this.BtnHouseAdd_Click);
            // 
            // tbHouseCost
            // 
            this.tbHouseCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbHouseCost.Location = new System.Drawing.Point(9, 194);
            this.tbHouseCost.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.tbHouseCost.Name = "tbHouseCost";
            this.tbHouseCost.Size = new System.Drawing.Size(156, 20);
            this.tbHouseCost.TabIndex = 6;
            this.tbHouseCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyDoublePress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цена одной шт.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbHouseCount
            // 
            this.tbHouseCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbHouseCount.Location = new System.Drawing.Point(9, 129);
            this.tbHouseCount.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.tbHouseCount.Name = "tbHouseCount";
            this.tbHouseCount.Size = new System.Drawing.Size(156, 20);
            this.tbHouseCount.TabIndex = 4;
            this.tbHouseCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyNumberPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(9, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Колличество";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(9, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Наименование";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(9, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Добавить";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHouseName
            // 
            this.tbHouseName.BackColor = System.Drawing.SystemColors.Window;
            this.tbHouseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbHouseName.Location = new System.Drawing.Point(9, 69);
            this.tbHouseName.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.tbHouseName.Name = "tbHouseName";
            this.tbHouseName.Size = new System.Drawing.Size(156, 20);
            this.tbHouseName.TabIndex = 2;
            this.tbHouseName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSaveLock,
            this.menuItemSaveJson,
            this.menuItemOpenFile});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // menuItemSaveLock
            // 
            this.menuItemSaveLock.Name = "menuItemSaveLock";
            this.menuItemSaveLock.Size = new System.Drawing.Size(266, 22);
            this.menuItemSaveLock.Text = "Сохранить в зашифрованном виде";
            this.menuItemSaveLock.Click += new System.EventHandler(this.MenuItemSaveLock_Click);
            // 
            // menuItemSaveJson
            // 
            this.menuItemSaveJson.Name = "menuItemSaveJson";
            this.menuItemSaveJson.Size = new System.Drawing.Size(266, 22);
            this.menuItemSaveJson.Text = "Сохранить в json";
            this.menuItemSaveJson.Click += new System.EventHandler(this.MenuItemSaveJson_Click);
            // 
            // menuItemOpenFile
            // 
            this.menuItemOpenFile.Name = "menuItemOpenFile";
            this.menuItemOpenFile.Size = new System.Drawing.Size(266, 22);
            this.menuItemOpenFile.Text = "Открыть файл";
            this.menuItemOpenFile.Click += new System.EventHandler(this.MenuItemOpenFile_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "mydb";
            this.saveFileDialog.FileName = "database";
            this.saveFileDialog.Filter = "Файл базы данных(*.mydb)|*.mydb";
            // 
            // saveJsonFileDialog
            // 
            this.saveJsonFileDialog.DefaultExt = "json";
            this.saveJsonFileDialog.FileName = "database";
            this.saveJsonFileDialog.Filter = "Json(*.json)|*.json";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файл базы данных(*.mydb)|*.mydb";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных дома №404";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHouse)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_flatNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.TextBox tb_resCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPersonFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveLock;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveJson;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveJsonFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnServiceClear;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.Button btnServiceAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbServiceName;
        private System.Windows.Forms.TextBox tbServiceCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dataGridViewHouse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnHouseClear;
        private System.Windows.Forms.Button btnHouseFilter;
        private System.Windows.Forms.Button btnHouseAdd;
        private System.Windows.Forms.TextBox tbHouseCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHouseCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbHouseName;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

