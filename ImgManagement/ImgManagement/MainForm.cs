using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgManagement
{
    public partial class MainForm : Form
    {
        
        private BackgroundWorker backgroundWorker;
        private String selectedFolderPath;
        private List<String> listImgType;
        private int loadedImageCount;
        private delegate void _SafeSetTextCall(string text);

        private Bitmap image;
        public MainForm()
        {
            InitializeComponent();
            backgroundWorker = new BackgroundWorker { WorkerSupportsCancellation = true, WorkerReportsProgress = true };
            
            backgroundWorker.ProgressChanged += ProgressChanged;
            backgroundWorker.RunWorkerCompleted += RunWorkerCompleted;
        }

        private void backgroundWorker_singleFolderWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;
            traverseFolders(selectedFolderPath);

        }

        private void backgroundWorker_allDiskWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                this.selectedFolderPath = drive;
                traverseFolders(selectedFolderPath);
            }

        }

    private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.imageCountStatusLabel.Text = "已载入" + loadedImageCount + "张图片";
            this.runStatusLabel.Text = "正在导入图片，请耐心等待...";

        }
        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.runStatusLabel.Text = "";
            MessageBox.Show("图片导入已完成","提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认退出软件？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImageForm loadImageForm = new LoadImageForm();
            loadImageForm.ShowDialog(this);
        }

        private void changeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

/*        public void setStatusLabel(String text)
        {
            this.imageCountStatusLabel.Text = text;
        }*/
        public void loadImageFileNameByPath(String folderPath, List<String> listFileType)
        {
            imgFileListBox.Items.Clear();
            loadedImageCount = 0;
            this.selectedFolderPath = folderPath;
            this.listImgType = listFileType;
            backgroundWorker.DoWork += backgroundWorker_singleFolderWork;
            this.backgroundWorker.RunWorkerAsync();

        }
        public void loadAllDiskImageFile(List<String> listFileType)
        {
            imgFileListBox.Items.Clear();
            this.listImgType = listFileType;
            loadedImageCount = 0;
            backgroundWorker.DoWork += backgroundWorker_allDiskWork;
            this.backgroundWorker.RunWorkerAsync();
        }
        private void traverseFolders(String folderPath)
        {
            
            try
            {
                DirectoryInfo folderInfo = new DirectoryInfo(folderPath);
                FileSystemInfo[] filesInfo = folderInfo.GetFileSystemInfos();
                DirectoryInfo[] subFolderInfo = folderInfo.GetDirectories();//文件夹
                for (int i = 0; i < filesInfo.Length; i++)
                {
                    string FileType = filesInfo[i].ToString().Substring(filesInfo[i].ToString().LastIndexOf(".") + 1, (filesInfo[i].ToString().Length - filesInfo[i].ToString().LastIndexOf(".") - 1));
                    FileType = FileType.ToLower();

                    if (this.listImgType.Contains(FileType))
                    //if (FileType == "jpg" || FileType == "png" || FileType == "bmp" || FileType == "gif" || FileType == "jpeg")
                    {
                        //imgFileListBox.Items.Add(filesInfo[i].ToString());
                        safeAddImgFile(filesInfo[i].FullName);
                        loadedImageCount++;
                        backgroundWorker.ReportProgress(0);
                        
                    }
                    backgroundWorker.ReportProgress(0);
                }
                //获取子文件夹内的文件列表，递归遍历  
                foreach (DirectoryInfo folders in subFolderInfo)
                {
                    traverseFolders(folders.FullName);
                }
            }
            catch (Exception e)//UnauthorizedAccessException
            {
                Console.WriteLine(e);
            }
        }



        private void safeAddImgFile(string text)
        {
            if (this.InvokeRequired)
            {
                _SafeSetTextCall call = delegate (string s) {
                    this.imgFileListBox.Items.Add(text);
                };

                this.Invoke(call, text);
            }
            else
                this.imgFileListBox.Items.Add(text);
        }

        private void imgFileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mainPictureBox.BackColor = Color.Black;

                string imagePath = imgFileListBox.SelectedItem.ToString();

                mainPictureBox.Image = Image.FromFile(imagePath);
                image = new Bitmap(imagePath);

                image.Dispose();

            }
            catch
            { }
        }
    }
}
