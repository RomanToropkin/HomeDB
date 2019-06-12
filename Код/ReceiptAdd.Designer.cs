namespace Cursach.View.EditForms
{
    partial class ReceiptAdd
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
            this.btnChange = new System.Windows.Forms.Button();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPersonInfo = new System.Windows.Forms.Label();
            this.labelDateInfo = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(17, 257);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(277, 23);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "Добавить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(17, 204);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(277, 20);
            this.tbCount.TabIndex = 13;
            this.tbCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyNumberPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Сумма";
            // 
            // labelPersonInfo
            // 
            this.labelPersonInfo.AutoSize = true;
            this.labelPersonInfo.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPersonInfo.Location = new System.Drawing.Point(12, 9);
            this.labelPersonInfo.Name = "labelPersonInfo";
            this.labelPersonInfo.Size = new System.Drawing.Size(60, 25);
            this.labelPersonInfo.TabIndex = 8;
            this.labelPersonInfo.Text = "Ф.И.О";
            // 
            // labelDateInfo
            // 
            this.labelDateInfo.AutoSize = true;
            this.labelDateInfo.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateInfo.Location = new System.Drawing.Point(12, 45);
            this.labelDateInfo.Name = "labelDateInfo";
            this.labelDateInfo.Size = new System.Drawing.Size(60, 25);
            this.labelDateInfo.TabIndex = 15;
            this.labelDateInfo.Text = "Ф.И.О";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(17, 133);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(277, 20);
            this.tbName.TabIndex = 17;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Наименование";
            // 
            // ReceiptAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 302);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDateInfo);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPersonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiptAdd";
            this.Text = "Добавить квитанцию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPersonInfo;
        private System.Windows.Forms.Label labelDateInfo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
    }
}