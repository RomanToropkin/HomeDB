namespace Cursach.View.EditForms
{
    partial class PersonEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFLat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ф.И.О";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(17, 49);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(277, 20);
            this.tbName.TabIndex = 2;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // tbFLat
            // 
            this.tbFLat.Location = new System.Drawing.Point(17, 129);
            this.tbFLat.Name = "tbFLat";
            this.tbFLat.Size = new System.Drawing.Size(277, 20);
            this.tbFLat.TabIndex = 4;
            this.tbFLat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyNumberPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер квартиры";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(17, 217);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(277, 20);
            this.tbCount.TabIndex = 6;
            this.tbCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyNumberPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Число жителей";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(17, 275);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(277, 23);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // PersonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 318);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFLat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "PersonEdit";
            this.Text = "Изменить";
            this.Load += new System.EventHandler(this.PersonEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbFLat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChange;
    }
}