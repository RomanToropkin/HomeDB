namespace Cursach
{
    partial class PersonFilters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sortAbs = new System.Windows.Forms.Label();
            this.sortCount = new System.Windows.Forms.Label();
            this.sortFlat = new System.Windows.Forms.Label();
            this.sortName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortD = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rbCount = new System.Windows.Forms.RadioButton();
            this.rbFlat = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGroup = new System.Windows.Forms.Button();
            this.rbGroupCount = new System.Windows.Forms.RadioButton();
            this.nudHigh = new System.Windows.Forms.NumericUpDown();
            this.nudLow = new System.Windows.Forms.NumericUpDown();
            this.rbGroupFlat = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(280, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(238, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(416, 117);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(102, 53);
            this.btnDown.TabIndex = 17;
            this.btnDown.Text = "Понизить приоритет";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(280, 117);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(97, 53);
            this.btnUp.TabIndex = 16;
            this.btnUp.Text = "Поднять приоритет";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sortAbs
            // 
            this.sortAbs.AutoSize = true;
            this.sortAbs.ForeColor = System.Drawing.Color.Blue;
            this.sortAbs.Location = new System.Drawing.Point(277, 69);
            this.sortAbs.Name = "sortAbs";
            this.sortAbs.Size = new System.Drawing.Size(181, 15);
            this.sortAbs.TabIndex = 15;
            this.sortAbs.Text = "Сортировка по возрастанию";
            this.sortAbs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_Moved);
            // 
            // sortCount
            // 
            this.sortCount.AutoSize = true;
            this.sortCount.Location = new System.Drawing.Point(277, 56);
            this.sortCount.Name = "sortCount";
            this.sortCount.Size = new System.Drawing.Size(201, 15);
            this.sortCount.TabIndex = 14;
            this.sortCount.Text = "Сортировка по числу жителей";
            this.sortCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_Moved);
            // 
            // sortFlat
            // 
            this.sortFlat.AutoSize = true;
            this.sortFlat.Location = new System.Drawing.Point(277, 43);
            this.sortFlat.Name = "sortFlat";
            this.sortFlat.Size = new System.Drawing.Size(208, 15);
            this.sortFlat.TabIndex = 12;
            this.sortFlat.Text = "Сортировка по номеру квартиры";
            this.sortFlat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_Moved);
            // 
            // sortName
            // 
            this.sortName.AutoSize = true;
            this.sortName.Location = new System.Drawing.Point(277, 30);
            this.sortName.Name = "sortName";
            this.sortName.Size = new System.Drawing.Size(141, 15);
            this.sortName.TabIndex = 11;
            this.sortName.Text = "Сортировка по имени";
            this.sortName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_Moved);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 139);
            this.listBox1.TabIndex = 10;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortD);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.sortName);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.sortFlat);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.sortCount);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.sortAbs);
            this.groupBox1.Font = new System.Drawing.Font("Amazing Grotesk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 222);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // sortD
            // 
            this.sortD.AutoSize = true;
            this.sortD.ForeColor = System.Drawing.Color.DarkGray;
            this.sortD.Location = new System.Drawing.Point(277, 84);
            this.sortD.Name = "sortD";
            this.sortD.Size = new System.Drawing.Size(164, 15);
            this.sortD.TabIndex = 19;
            this.sortD.Text = "Сортировка по убыванию";
            this.sortD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_Moved);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.rbCount);
            this.groupBox2.Controls.Add(this.rbFlat);
            this.groupBox2.Controls.Add(this.rbName);
            this.groupBox2.Controls.Add(this.tbSearch);
            this.groupBox2.Font = new System.Drawing.Font("Amazing Grotesk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 160);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbCount
            // 
            this.rbCount.AutoSize = true;
            this.rbCount.Location = new System.Drawing.Point(10, 107);
            this.rbCount.Name = "rbCount";
            this.rbCount.Size = new System.Drawing.Size(145, 19);
            this.rbCount.TabIndex = 3;
            this.rbCount.Text = "По числу жителей";
            this.rbCount.UseVisualStyleBackColor = true;
            // 
            // rbFlat
            // 
            this.rbFlat.AutoSize = true;
            this.rbFlat.Location = new System.Drawing.Point(10, 82);
            this.rbFlat.Name = "rbFlat";
            this.rbFlat.Size = new System.Drawing.Size(152, 19);
            this.rbFlat.TabIndex = 2;
            this.rbFlat.Text = "По номеру квартиры";
            this.rbFlat.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Checked = true;
            this.rbName.Location = new System.Drawing.Point(10, 57);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(85, 19);
            this.rbName.TabIndex = 1;
            this.rbName.TabStop = true;
            this.rbName.Text = "По имени";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(10, 29);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(260, 21);
            this.tbSearch.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnGroup);
            this.groupBox3.Controls.Add(this.rbGroupCount);
            this.groupBox3.Controls.Add(this.nudHigh);
            this.groupBox3.Controls.Add(this.nudLow);
            this.groupBox3.Controls.Add(this.rbGroupFlat);
            this.groupBox3.Font = new System.Drawing.Font("Amazing Grotesk", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(307, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 160);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выборка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "до";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "от";
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(13, 131);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(210, 23);
            this.btnGroup.TabIndex = 11;
            this.btnGroup.Text = "Применить";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // rbGroupCount
            // 
            this.rbGroupCount.AutoSize = true;
            this.rbGroupCount.Location = new System.Drawing.Point(13, 57);
            this.rbGroupCount.Name = "rbGroupCount";
            this.rbGroupCount.Size = new System.Drawing.Size(145, 19);
            this.rbGroupCount.TabIndex = 10;
            this.rbGroupCount.Text = "По числу жителей";
            this.rbGroupCount.UseVisualStyleBackColor = true;
            // 
            // nudHigh
            // 
            this.nudHigh.Location = new System.Drawing.Point(152, 82);
            this.nudHigh.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudHigh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHigh.Name = "nudHigh";
            this.nudHigh.Size = new System.Drawing.Size(71, 21);
            this.nudHigh.TabIndex = 8;
            this.nudHigh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudLow
            // 
            this.nudLow.Location = new System.Drawing.Point(37, 82);
            this.nudLow.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLow.Name = "nudLow";
            this.nudLow.Size = new System.Drawing.Size(72, 21);
            this.nudLow.TabIndex = 6;
            this.nudLow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLow.ValueChanged += new System.EventHandler(this.nudLow_ValueChanged);
            // 
            // rbGroupFlat
            // 
            this.rbGroupFlat.AutoSize = true;
            this.rbGroupFlat.Checked = true;
            this.rbGroupFlat.Location = new System.Drawing.Point(13, 29);
            this.rbGroupFlat.Name = "rbGroupFlat";
            this.rbGroupFlat.Size = new System.Drawing.Size(163, 19);
            this.rbGroupFlat.TabIndex = 5;
            this.rbGroupFlat.TabStop = true;
            this.rbGroupFlat.Text = "По диапазону квартир";
            this.rbGroupFlat.UseVisualStyleBackColor = true;
            // 
            // PersonFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 39);
            this.Name = "PersonFilters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильтр";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sortAbs;
        private System.Windows.Forms.Label sortCount;
        private System.Windows.Forms.Label sortFlat;
        private System.Windows.Forms.Label sortName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbCount;
        private System.Windows.Forms.RadioButton rbFlat;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label sortD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.RadioButton rbGroupCount;
        private System.Windows.Forms.NumericUpDown nudHigh;
        private System.Windows.Forms.NumericUpDown nudLow;
        private System.Windows.Forms.RadioButton rbGroupFlat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}