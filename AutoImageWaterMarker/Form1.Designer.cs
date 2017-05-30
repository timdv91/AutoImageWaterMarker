namespace AutoImageWaterMarker
{
    partial class Form1
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnChooseWaterMarkImg = new System.Windows.Forms.Button();
            this.txtImageFolderPath = new System.Windows.Forms.TextBox();
            this.txtWatermarkImg = new System.Windows.Forms.TextBox();
            this.rtxtInfoBox = new System.Windows.Forms.RichTextBox();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.radioButtonRB = new System.Windows.Forms.RadioButton();
            this.radioButtonRT = new System.Windows.Forms.RadioButton();
            this.radioButtonLT = new System.Windows.Forms.RadioButton();
            this.radioButtonLB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTC = new System.Windows.Forms.RadioButton();
            this.radioButtonBC = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(646, 70);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(137, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(13, 12);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(138, 23);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Choose image folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnChooseWaterMarkImg
            // 
            this.btnChooseWaterMarkImg.Location = new System.Drawing.Point(12, 41);
            this.btnChooseWaterMarkImg.Name = "btnChooseWaterMarkImg";
            this.btnChooseWaterMarkImg.Size = new System.Drawing.Size(138, 23);
            this.btnChooseWaterMarkImg.TabIndex = 2;
            this.btnChooseWaterMarkImg.Text = "Choose watermark image";
            this.btnChooseWaterMarkImg.UseVisualStyleBackColor = true;
            this.btnChooseWaterMarkImg.Click += new System.EventHandler(this.btnChooseWaterMarkImg_Click);
            // 
            // txtImageFolderPath
            // 
            this.txtImageFolderPath.Location = new System.Drawing.Point(157, 14);
            this.txtImageFolderPath.Name = "txtImageFolderPath";
            this.txtImageFolderPath.Size = new System.Drawing.Size(626, 20);
            this.txtImageFolderPath.TabIndex = 3;
            // 
            // txtWatermarkImg
            // 
            this.txtWatermarkImg.Location = new System.Drawing.Point(157, 43);
            this.txtWatermarkImg.Name = "txtWatermarkImg";
            this.txtWatermarkImg.Size = new System.Drawing.Size(626, 20);
            this.txtWatermarkImg.TabIndex = 4;
            // 
            // rtxtInfoBox
            // 
            this.rtxtInfoBox.Location = new System.Drawing.Point(13, 288);
            this.rtxtInfoBox.Name = "rtxtInfoBox";
            this.rtxtInfoBox.Size = new System.Drawing.Size(771, 362);
            this.rtxtInfoBox.TabIndex = 5;
            this.rtxtInfoBox.Text = "";
            this.rtxtInfoBox.TextChanged += new System.EventHandler(this.rtxtInfoBox_TextChanged);
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Location = new System.Drawing.Point(12, 70);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(138, 23);
            this.btnSaveLocation.TabIndex = 6;
            this.btnSaveLocation.Text = "Save location";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(157, 72);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(483, 20);
            this.txtSavePath.TabIndex = 7;
            // 
            // radioButtonRB
            // 
            this.radioButtonRB.AutoSize = true;
            this.radioButtonRB.Location = new System.Drawing.Point(679, 109);
            this.radioButtonRB.Name = "radioButtonRB";
            this.radioButtonRB.Size = new System.Drawing.Size(86, 17);
            this.radioButtonRB.TabIndex = 8;
            this.radioButtonRB.TabStop = true;
            this.radioButtonRB.Text = "Right Bottom";
            this.radioButtonRB.UseVisualStyleBackColor = true;
            // 
            // radioButtonRT
            // 
            this.radioButtonRT.AutoSize = true;
            this.radioButtonRT.Location = new System.Drawing.Point(679, 19);
            this.radioButtonRT.Name = "radioButtonRT";
            this.radioButtonRT.Size = new System.Drawing.Size(72, 17);
            this.radioButtonRT.TabIndex = 9;
            this.radioButtonRT.TabStop = true;
            this.radioButtonRT.Text = "Right Top";
            this.radioButtonRT.UseVisualStyleBackColor = true;
            // 
            // radioButtonLT
            // 
            this.radioButtonLT.AutoSize = true;
            this.radioButtonLT.Location = new System.Drawing.Point(6, 19);
            this.radioButtonLT.Name = "radioButtonLT";
            this.radioButtonLT.Size = new System.Drawing.Size(65, 17);
            this.radioButtonLT.TabIndex = 10;
            this.radioButtonLT.TabStop = true;
            this.radioButtonLT.Text = "Left Top";
            this.radioButtonLT.UseVisualStyleBackColor = true;
            // 
            // radioButtonLB
            // 
            this.radioButtonLB.AutoSize = true;
            this.radioButtonLB.Location = new System.Drawing.Point(6, 109);
            this.radioButtonLB.Name = "radioButtonLB";
            this.radioButtonLB.Size = new System.Drawing.Size(79, 17);
            this.radioButtonLB.TabIndex = 11;
            this.radioButtonLB.TabStop = true;
            this.radioButtonLB.Text = "Left Bottom";
            this.radioButtonLB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonC);
            this.groupBox1.Controls.Add(this.radioButtonBC);
            this.groupBox1.Controls.Add(this.radioButtonTC);
            this.groupBox1.Controls.Add(this.radioButtonRB);
            this.groupBox1.Controls.Add(this.radioButtonLT);
            this.groupBox1.Controls.Add(this.radioButtonLB);
            this.groupBox1.Controls.Add(this.radioButtonRT);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 141);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select watermark position:";
            // 
            // radioButtonTC
            // 
            this.radioButtonTC.AutoSize = true;
            this.radioButtonTC.Location = new System.Drawing.Point(340, 19);
            this.radioButtonTC.Name = "radioButtonTC";
            this.radioButtonTC.Size = new System.Drawing.Size(78, 17);
            this.radioButtonTC.TabIndex = 12;
            this.radioButtonTC.TabStop = true;
            this.radioButtonTC.Text = "Top Center";
            this.radioButtonTC.UseVisualStyleBackColor = true;
            // 
            // radioButtonBC
            // 
            this.radioButtonBC.AutoSize = true;
            this.radioButtonBC.Location = new System.Drawing.Point(340, 109);
            this.radioButtonBC.Name = "radioButtonBC";
            this.radioButtonBC.Size = new System.Drawing.Size(92, 17);
            this.radioButtonBC.TabIndex = 13;
            this.radioButtonBC.TabStop = true;
            this.radioButtonBC.Text = "Bottom Center";
            this.radioButtonBC.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(340, 62);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(56, 17);
            this.radioButtonC.TabIndex = 14;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "Center";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 259);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(770, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 687);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.rtxtInfoBox);
            this.Controls.Add(this.txtWatermarkImg);
            this.Controls.Add(this.txtImageFolderPath);
            this.Controls.Add(this.btnChooseWaterMarkImg);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Watermark generator by TimDV91";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnChooseWaterMarkImg;
        private System.Windows.Forms.TextBox txtImageFolderPath;
        private System.Windows.Forms.TextBox txtWatermarkImg;
        private System.Windows.Forms.RichTextBox rtxtInfoBox;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.RadioButton radioButtonRB;
        private System.Windows.Forms.RadioButton radioButtonRT;
        private System.Windows.Forms.RadioButton radioButtonLT;
        private System.Windows.Forms.RadioButton radioButtonLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonBC;
        private System.Windows.Forms.RadioButton radioButtonTC;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

