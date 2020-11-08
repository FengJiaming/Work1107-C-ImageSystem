using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgManagement
{
    public partial class LoadImageForm : Form
    {
        public LoadImageForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadImageForm_Load(object sender, EventArgs e)
        {
            pathTextBox.Enabled = false;
            chooseFolderButton.Enabled = false;
        }

        private void singleDictRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(singleDictRadioButton.Checked == true)
            {
                this.pathTextBox.Enabled = true;
                this.chooseFolderButton.Enabled = true;
            } else
            {
                this.pathTextBox.Enabled = false;
                this.chooseFolderButton.Enabled = false;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner; 
            
            try
            {
                if (!checkImageTypeOption())
                    throw new Exception("必须至少选择一种图片格式");
                if (!checkLoadingOption())
                    throw new Exception("请选择图片导入方式");
                if (!checkFolderPath())
                    throw new Exception("导入文件夹路径不能为空");
                this.Hide();

                if (singleDictRadioButton.Checked)
                    mainForm.loadImageFileNameByPath(this.pathTextBox.Text, addImageType());
                if (allDiskRadioButton.Checked)
                    mainForm.loadAllDiskImageFile(addImageType());
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

     
        }

        private bool checkImageTypeOption()
        {
            if (pngCheckBox.Checked || jpgCheckBox.Checked || jpegCheckBox.Checked || bmpCheckBox.Checked || gifCheckBox.Checked)
                return true;
            return false;
        }

        private bool checkLoadingOption()
        {
            if (singleDictRadioButton.Checked || allDiskRadioButton.Checked)
                return true;
            return false;
        }

        private bool checkFolderPath()
        {
            if (singleDictRadioButton.Checked)
                if ("".Equals(pathTextBox.Text) || pathTextBox.Text == null)
                    return false;
            return true;
        }
        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                this.pathTextBox.Text = folderBrowserDialog.SelectedPath;
        
        }
        private List<String> addImageType()
        {
            List<String> listImageType = new List<string>();
            if (pngCheckBox.Checked == true)
                listImageType.Add("png");
            if (jpgCheckBox.Checked == true)
                listImageType.Add("jpg");
            if (jpegCheckBox.Checked == true)
                listImageType.Add("jped");
            if (bmpCheckBox.Checked == true)
                listImageType.Add("bmp");
            if (gifCheckBox.Checked == true)
                listImageType.Add("gif");
            return listImageType;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(SystemColors.ControlDark);
            pen.DashStyle = DashStyle.Dash;
            e.Graphics.DrawRectangle(pen, panel1.DisplayRectangle);
            e.Graphics.DrawLine(pen, 0, 0, 0, panel1.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, panel1.Width - 0, 0);
            e.Graphics.DrawLine(pen, panel1.Width - 1, panel1.Height - 1, 0, panel1.Height - 1);
            e.Graphics.DrawLine(pen, panel1.Width - 1, panel1.Height - 1, panel1.Width - 1, 0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
