namespace ImgManagement
{
    partial class LoadImageForm
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
            this.singleDictRadioButton = new System.Windows.Forms.RadioButton();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allDiskRadioButton = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pngCheckBox = new System.Windows.Forms.CheckBox();
            this.jpgCheckBox = new System.Windows.Forms.CheckBox();
            this.jpegCheckBox = new System.Windows.Forms.CheckBox();
            this.bmpCheckBox = new System.Windows.Forms.CheckBox();
            this.gifCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // singleDictRadioButton
            // 
            this.singleDictRadioButton.AutoSize = true;
            this.singleDictRadioButton.Location = new System.Drawing.Point(14, 17);
            this.singleDictRadioButton.Name = "singleDictRadioButton";
            this.singleDictRadioButton.Size = new System.Drawing.Size(107, 16);
            this.singleDictRadioButton.TabIndex = 0;
            this.singleDictRadioButton.TabStop = true;
            this.singleDictRadioButton.Text = "扫描选定文件夹";
            this.singleDictRadioButton.UseVisualStyleBackColor = true;
            this.singleDictRadioButton.CheckedChanged += new System.EventHandler(this.singleDictRadioButton_CheckedChanged);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(14, 39);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(234, 21);
            this.pathTextBox.TabIndex = 2;
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.Location = new System.Drawing.Point(254, 39);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(45, 23);
            this.chooseFolderButton.TabIndex = 3;
            this.chooseFolderButton.Text = "选择";
            this.chooseFolderButton.UseVisualStyleBackColor = true;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(90, 179);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "确认";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.allDiskRadioButton);
            this.panel1.Controls.Add(this.singleDictRadioButton);
            this.panel1.Controls.Add(this.pathTextBox);
            this.panel1.Controls.Add(this.chooseFolderButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 110);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // allDiskRadioButton
            // 
            this.allDiskRadioButton.AutoSize = true;
            this.allDiskRadioButton.Location = new System.Drawing.Point(14, 77);
            this.allDiskRadioButton.Name = "allDiskRadioButton";
            this.allDiskRadioButton.Size = new System.Drawing.Size(71, 16);
            this.allDiskRadioButton.TabIndex = 4;
            this.allDiskRadioButton.TabStop = true;
            this.allDiskRadioButton.Text = "扫描全盘";
            this.allDiskRadioButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(171, 179);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pngCheckBox
            // 
            this.pngCheckBox.AutoSize = true;
            this.pngCheckBox.Location = new System.Drawing.Point(14, 3);
            this.pngCheckBox.Name = "pngCheckBox";
            this.pngCheckBox.Size = new System.Drawing.Size(48, 16);
            this.pngCheckBox.TabIndex = 8;
            this.pngCheckBox.Text = ".png";
            this.pngCheckBox.UseVisualStyleBackColor = true;
            // 
            // jpgCheckBox
            // 
            this.jpgCheckBox.AutoSize = true;
            this.jpgCheckBox.Location = new System.Drawing.Point(68, 3);
            this.jpgCheckBox.Name = "jpgCheckBox";
            this.jpgCheckBox.Size = new System.Drawing.Size(48, 16);
            this.jpgCheckBox.TabIndex = 9;
            this.jpgCheckBox.Text = ".jpg";
            this.jpgCheckBox.UseVisualStyleBackColor = true;
            // 
            // jpegCheckBox
            // 
            this.jpegCheckBox.AutoSize = true;
            this.jpegCheckBox.Location = new System.Drawing.Point(122, 3);
            this.jpegCheckBox.Name = "jpegCheckBox";
            this.jpegCheckBox.Size = new System.Drawing.Size(54, 16);
            this.jpegCheckBox.TabIndex = 10;
            this.jpegCheckBox.Text = ".jpeg";
            this.jpegCheckBox.UseVisualStyleBackColor = true;
            // 
            // bmpCheckBox
            // 
            this.bmpCheckBox.AutoSize = true;
            this.bmpCheckBox.Location = new System.Drawing.Point(182, 3);
            this.bmpCheckBox.Name = "bmpCheckBox";
            this.bmpCheckBox.Size = new System.Drawing.Size(48, 16);
            this.bmpCheckBox.TabIndex = 11;
            this.bmpCheckBox.Text = ".bmp";
            this.bmpCheckBox.UseVisualStyleBackColor = true;
            // 
            // gifCheckBox
            // 
            this.gifCheckBox.AutoSize = true;
            this.gifCheckBox.Location = new System.Drawing.Point(236, 3);
            this.gifCheckBox.Name = "gifCheckBox";
            this.gifCheckBox.Size = new System.Drawing.Size(48, 16);
            this.gifCheckBox.TabIndex = 12;
            this.gifCheckBox.Text = ".gif";
            this.gifCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pngCheckBox);
            this.panel2.Controls.Add(this.gifCheckBox);
            this.panel2.Controls.Add(this.jpgCheckBox);
            this.panel2.Controls.Add(this.bmpCheckBox);
            this.panel2.Controls.Add(this.jpegCheckBox);
            this.panel2.Location = new System.Drawing.Point(26, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 23);
            this.panel2.TabIndex = 13;
            // 
            // LoadImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 234);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.confirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoadImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入图片";
            this.Load += new System.EventHandler(this.LoadImageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton singleDictRadioButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button chooseFolderButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton allDiskRadioButton;
        private System.Windows.Forms.CheckBox pngCheckBox;
        private System.Windows.Forms.CheckBox jpgCheckBox;
        private System.Windows.Forms.CheckBox jpegCheckBox;
        private System.Windows.Forms.CheckBox bmpCheckBox;
        private System.Windows.Forms.CheckBox gifCheckBox;
        private System.Windows.Forms.Panel panel2;
    }
}