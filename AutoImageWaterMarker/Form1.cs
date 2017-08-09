using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoImageWaterMarker
{
    public partial class Form1 : Form
    {
        BackgroundWorker cpu0 = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
            startupConfig();
        }

        void startupConfig()
        {
            radioButtonRB.Checked = true;

            cpu0.DoWork += Cpu0_DoWork;
            cpu0.ProgressChanged += Cpu0_ProgressChanged;
            cpu0.RunWorkerCompleted += Cpu0_RunWorkerCompleted;
            cpu0.WorkerReportsProgress = true;
            cpu0.WorkerSupportsCancellation = true;
        }

        //Select folder with images:
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
                txtImageFolderPath.Text = fbd.SelectedPath.ToString();
        }

        //select watermark image:
        private void btnChooseWaterMarkImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
                txtWatermarkImg.Text = ofd.FileName.ToString();
        }

        //select save location:
        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
                txtSavePath.Text = fbd.SelectedPath.ToString();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (btnRun.Text == "Run")
            {
                //clear vars at start:
                progressBar1.Value = 0;
                rtxtInfoBox.Text = "";

                if (txtImageFolderPath.Text == "" || txtSavePath.Text == "" || txtWatermarkImg.Text == "")
                {
                    MessageBox.Show("You have to give alle file and folder paths before the program can run!");
                    return;
                }

                string[] imageList = getImagesFromFolder(txtImageFolderPath.Text.ToString());

                btnRun.Text = "Cancel";

                cpu0.RunWorkerAsync(imageList);
            }
            else
            {
                //cancel running backgroundworker:
                cpu0.CancelAsync();
                MessageBox.Show("Work canceled. Could not watermark all pictures!");
                btnRun.Text = "Run";
            }
        }

        //returns array of all images:
        public string[] getImagesFromFolder(string strFolderPath)
        {
            rtxtInfoBox.Text += "Detecting all files in selected folder: " + strFolderPath + "\n";

            string[] myFiles = Directory.GetFiles(strFolderPath);

            rtxtInfoBox.Text += "Counting " + myFiles.Count() + " files in this folder." + "\n";

            progressBar1.Maximum = myFiles.Count();

            return myFiles;
        }

        //places watermark on top of image
        public void setImageWaterMark(string SourceImgPath, string watermarkIMGpath, string savePath)
        {
            //rtxtInfoBox.Text += "Adding watermark on image: " + SourceImgPath + "\n";

            using (Image image = Image.FromFile(SourceImgPath))
            using (Image watermarkImage = Image.FromFile(watermarkIMGpath))
            using (Graphics imageGraphics = Graphics.FromImage(image))
            using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
            {
                int[] xy = getWaterMarkPosition(image, watermarkImage);
                int x = xy[0];  //(image.Width / 2 - watermarkImage.Width / 2);
                int y = xy[1];  //(image.Height / 2 - watermarkImage.Height / 2);

                watermarkBrush.TranslateTransform(x, y);
                imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(watermarkImage.Width + 1, watermarkImage.Height)));
                image.Save(savePath);
            }

            //rtxtInfoBox.Text += "Adding watermark successfull. \n";
        }

        //set watermark position with radiobuttons:
        int[] getWaterMarkPosition(Image img, Image watermarkImg)
        {
            int x = -1, y = -1;

            //center
            if(radioButtonC.Checked)
            {
                x = (img.Width / 2 - watermarkImg.Width / 2);
                y = (img.Height / 2 - watermarkImg.Height / 2);
            }

            //center top:
            if (radioButtonTC.Checked)
            {
                x = (img.Width / 2 - watermarkImg.Width / 2);
                y = 0;
            }

            //center bottom:
            if (radioButtonBC.Checked)
            {
                x = (img.Width / 2 - watermarkImg.Width / 2);
                y = (img.Height - watermarkImg.Height);
            }

            //left top:
            if (radioButtonLT.Checked)
            {
                x = 0;
                y = 0;
            }

            //Left Bottom:
            if (radioButtonLB.Checked)
            {
                x = 0;
                y = (img.Height - watermarkImg.Height);
            }

            //Right Bottom:
            if (radioButtonRB.Checked)
            {
                x = (img.Width - watermarkImg.Width);
                y = (img.Height - watermarkImg.Height);
            }

            //Right top
            if (radioButtonRT.Checked)
            {
                x = (img.Width - watermarkImg.Width);
                y = 0;
            }

            //return xy as array.
            int[] xy = new int[2];
            xy[0] = x;
            xy[1] = y;

            return xy;
        }

        //Scroll rich textbox automaticly to bottom:
        private void rtxtInfoBox_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            rtxtInfoBox.SelectionStart = rtxtInfoBox.Text.Length;
            // scroll it automatically
            rtxtInfoBox.ScrollToCaret();
        }

        //Backgroundworkers:
        //================================================================================
        private void Cpu0_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] imageList = (String[]) e.Argument;
            string reportProgressString = "";

            int I = 0;
            foreach (string sourceImage in imageList)
            {
                //get filename:
                //rtxtInfoBox.Text += "Loading image from path: " + sourceImage + "\n";
                string fileName = Path.GetFileName(sourceImage);

                //check extension of file:
                string[] fileNameSplit = fileName.Split('.');
                if (fileNameSplit[1] == "jpg" || fileNameSplit[1] == "JPG" || fileNameSplit[1] == "png")
                {
                    //rtxtInfoBox.Text += "Image loaded with filename: " + fileName + "\n";
                    setImageWaterMark(sourceImage, txtWatermarkImg.Text, txtSavePath.Text + "\\" + fileName);
                    reportProgressString = "Done:" + sourceImage + "\n";
                }
                else
                {
                    //rtxtInfoBox.Text += "This file is not an image! Skipping file. \n";
                    reportProgressString = "This file is not an image! Skipping file. " + sourceImage + "\n";
                }

                //report progress:
                I++;
                cpu0.ReportProgress(I, reportProgressString);

                // check status on each step
                if (cpu0.CancellationPending == true)
                {
                    cpu0.ReportProgress(I, "\nWork canceled...\n");
                    e.Cancel = true;
                    return; // abort work, if it's cancelled
                }
            }
        }

        private void Cpu0_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //set progressbar:
            if ((progressBar1.Value + 1) <= progressBar1.Maximum)
                progressBar1.Value = e.ProgressPercentage;

            rtxtInfoBox.Text += (String)e.UserState;
        }

        private void Cpu0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (rtxtInfoBox.Text.Contains("Work canceled..."))
                return;

            progressBar1.Value = progressBar1.Maximum;

            rtxtInfoBox.Text += "Work done! \n";
            MessageBox.Show("Work completed, all images have now a watermark.");
            btnRun.Text = "Run";
        }
    }
}
