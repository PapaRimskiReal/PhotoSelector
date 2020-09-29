namespace PhotoSelector
{
    partial class FrmMain
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
            this.BtnToSelectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnFolderForSaves = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelNextPictureLabel = new System.Windows.Forms.Label();
            this.LabelNextPicture = new System.Windows.Forms.Label();
            this.BtnPreviousPicture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPreviousPicture = new System.Windows.Forms.Label();
            this.BtnSavePicture = new System.Windows.Forms.Button();
            this.BtnDeletePicture = new System.Windows.Forms.Button();
            this.BtnNextFolder = new System.Windows.Forms.Button();
            this.BtnPreviousFolder = new System.Windows.Forms.Button();
            this.BtnEndOfSelection = new System.Windows.Forms.Button();
            this.BtnDeleteFolder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelSavePicture = new System.Windows.Forms.Label();
            this.labelDeletePicture = new System.Windows.Forms.Label();
            this.labelNextFolder = new System.Windows.Forms.Label();
            this.labelPreviousFolder = new System.Windows.Forms.Label();
            this.labelEndOfSelection = new System.Windows.Forms.Label();
            this.labelDeleteFolder = new System.Windows.Forms.Label();
            this.labelPushAnyButton = new System.Windows.Forms.Label();
            this.labelCheckForDeleteStatus = new System.Windows.Forms.Label();
            this.checkBoxForDeleteStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxDontDelete = new System.Windows.Forms.CheckBox();
            this.labelDontDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnToSelectFolder
            // 
            this.BtnToSelectFolder.Location = new System.Drawing.Point(34, 22);
            this.BtnToSelectFolder.Name = "BtnToSelectFolder";
            this.BtnToSelectFolder.Size = new System.Drawing.Size(128, 55);
            this.BtnToSelectFolder.TabIndex = 0;
            this.BtnToSelectFolder.Text = "Select Folder";
            this.BtnToSelectFolder.UseVisualStyleBackColor = true;
            this.BtnToSelectFolder.Click += new System.EventHandler(this.BtnSelectFolder);
            // 
            // BtnFolderForSaves
            // 
            this.BtnFolderForSaves.Location = new System.Drawing.Point(34, 83);
            this.BtnFolderForSaves.Name = "BtnFolderForSaves";
            this.BtnFolderForSaves.Size = new System.Drawing.Size(128, 55);
            this.BtnFolderForSaves.TabIndex = 1;
            this.BtnFolderForSaves.Text = "Folder for saves";
            this.BtnFolderForSaves.UseVisualStyleBackColor = true;
            this.BtnFolderForSaves.Click += new System.EventHandler(this.BtnFolderForSaves_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelNextPictureLabel
            // 
            this.LabelNextPictureLabel.AutoSize = true;
            this.LabelNextPictureLabel.Location = new System.Drawing.Point(470, 48);
            this.LabelNextPictureLabel.Name = "LabelNextPictureLabel";
            this.LabelNextPictureLabel.Size = new System.Drawing.Size(65, 13);
            this.LabelNextPictureLabel.TabIndex = 3;
            this.LabelNextPictureLabel.Text = "Next Picture";
            // 
            // LabelNextPicture
            // 
            this.LabelNextPicture.AutoSize = true;
            this.LabelNextPicture.Location = new System.Drawing.Point(561, 48);
            this.LabelNextPicture.Name = "LabelNextPicture";
            this.LabelNextPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelNextPicture.Size = new System.Drawing.Size(60, 13);
            this.LabelNextPicture.TabIndex = 4;
            this.LabelNextPicture.Text = "nextPicture";
            // 
            // BtnPreviousPicture
            // 
            this.BtnPreviousPicture.Location = new System.Drawing.Point(640, 75);
            this.BtnPreviousPicture.Name = "BtnPreviousPicture";
            this.BtnPreviousPicture.Size = new System.Drawing.Size(97, 30);
            this.BtnPreviousPicture.TabIndex = 5;
            this.BtnPreviousPicture.Text = "Change";
            this.BtnPreviousPicture.UseVisualStyleBackColor = true;
            this.BtnPreviousPicture.Click += new System.EventHandler(this.BtnPreviousPicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Previous Picture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Save Picture";
            // 
            // labelPreviousPicture
            // 
            this.labelPreviousPicture.AutoSize = true;
            this.labelPreviousPicture.Location = new System.Drawing.Point(561, 84);
            this.labelPreviousPicture.Name = "labelPreviousPicture";
            this.labelPreviousPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPreviousPicture.Size = new System.Drawing.Size(60, 13);
            this.labelPreviousPicture.TabIndex = 8;
            this.labelPreviousPicture.Text = "nextPicture";
            // 
            // BtnSavePicture
            // 
            this.BtnSavePicture.Location = new System.Drawing.Point(640, 111);
            this.BtnSavePicture.Name = "BtnSavePicture";
            this.BtnSavePicture.Size = new System.Drawing.Size(97, 30);
            this.BtnSavePicture.TabIndex = 9;
            this.BtnSavePicture.Text = "Change";
            this.BtnSavePicture.UseVisualStyleBackColor = true;
            this.BtnSavePicture.Click += new System.EventHandler(this.BtnSavePicture_Click);
            // 
            // BtnDeletePicture
            // 
            this.BtnDeletePicture.Location = new System.Drawing.Point(640, 147);
            this.BtnDeletePicture.Name = "BtnDeletePicture";
            this.BtnDeletePicture.Size = new System.Drawing.Size(97, 30);
            this.BtnDeletePicture.TabIndex = 10;
            this.BtnDeletePicture.Text = "Change";
            this.BtnDeletePicture.UseVisualStyleBackColor = true;
            this.BtnDeletePicture.Click += new System.EventHandler(this.BtnDeletePicture_Click);
            // 
            // BtnNextFolder
            // 
            this.BtnNextFolder.Location = new System.Drawing.Point(640, 183);
            this.BtnNextFolder.Name = "BtnNextFolder";
            this.BtnNextFolder.Size = new System.Drawing.Size(97, 30);
            this.BtnNextFolder.TabIndex = 11;
            this.BtnNextFolder.Text = "Change";
            this.BtnNextFolder.UseVisualStyleBackColor = true;
            this.BtnNextFolder.Click += new System.EventHandler(this.BtnNextFolder_Click_1);
            // 
            // BtnPreviousFolder
            // 
            this.BtnPreviousFolder.Location = new System.Drawing.Point(640, 219);
            this.BtnPreviousFolder.Name = "BtnPreviousFolder";
            this.BtnPreviousFolder.Size = new System.Drawing.Size(97, 30);
            this.BtnPreviousFolder.TabIndex = 12;
            this.BtnPreviousFolder.Text = "Change";
            this.BtnPreviousFolder.UseVisualStyleBackColor = true;
            this.BtnPreviousFolder.Click += new System.EventHandler(this.BtnPreviousFolder_Click);
            // 
            // BtnEndOfSelection
            // 
            this.BtnEndOfSelection.Location = new System.Drawing.Point(640, 255);
            this.BtnEndOfSelection.Name = "BtnEndOfSelection";
            this.BtnEndOfSelection.Size = new System.Drawing.Size(97, 30);
            this.BtnEndOfSelection.TabIndex = 13;
            this.BtnEndOfSelection.Text = "Change";
            this.BtnEndOfSelection.UseVisualStyleBackColor = true;
            this.BtnEndOfSelection.Click += new System.EventHandler(this.BtnEndOfSelection_Click);
            // 
            // BtnDeleteFolder
            // 
            this.BtnDeleteFolder.Location = new System.Drawing.Point(640, 291);
            this.BtnDeleteFolder.Name = "BtnDeleteFolder";
            this.BtnDeleteFolder.Size = new System.Drawing.Size(97, 30);
            this.BtnDeleteFolder.TabIndex = 14;
            this.BtnDeleteFolder.Text = "Change";
            this.BtnDeleteFolder.UseVisualStyleBackColor = true;
            this.BtnDeleteFolder.Click += new System.EventHandler(this.BtnDeleteFolder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Delete Picture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Next Folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Previous Folder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "End of Slection";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Delete Folder";
            // 
            // labelSavePicture
            // 
            this.labelSavePicture.AutoSize = true;
            this.labelSavePicture.Location = new System.Drawing.Point(561, 120);
            this.labelSavePicture.Name = "labelSavePicture";
            this.labelSavePicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSavePicture.Size = new System.Drawing.Size(60, 13);
            this.labelSavePicture.TabIndex = 20;
            this.labelSavePicture.Text = "nextPicture";
            // 
            // labelDeletePicture
            // 
            this.labelDeletePicture.AutoSize = true;
            this.labelDeletePicture.Location = new System.Drawing.Point(561, 156);
            this.labelDeletePicture.Name = "labelDeletePicture";
            this.labelDeletePicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDeletePicture.Size = new System.Drawing.Size(60, 13);
            this.labelDeletePicture.TabIndex = 21;
            this.labelDeletePicture.Text = "nextPicture";
            // 
            // labelNextFolder
            // 
            this.labelNextFolder.AutoSize = true;
            this.labelNextFolder.Location = new System.Drawing.Point(561, 192);
            this.labelNextFolder.Name = "labelNextFolder";
            this.labelNextFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNextFolder.Size = new System.Drawing.Size(60, 13);
            this.labelNextFolder.TabIndex = 22;
            this.labelNextFolder.Text = "nextPicture";
            // 
            // labelPreviousFolder
            // 
            this.labelPreviousFolder.AutoSize = true;
            this.labelPreviousFolder.Location = new System.Drawing.Point(561, 228);
            this.labelPreviousFolder.Name = "labelPreviousFolder";
            this.labelPreviousFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPreviousFolder.Size = new System.Drawing.Size(60, 13);
            this.labelPreviousFolder.TabIndex = 23;
            this.labelPreviousFolder.Text = "nextPicture";
            // 
            // labelEndOfSelection
            // 
            this.labelEndOfSelection.AutoSize = true;
            this.labelEndOfSelection.Location = new System.Drawing.Point(561, 264);
            this.labelEndOfSelection.Name = "labelEndOfSelection";
            this.labelEndOfSelection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEndOfSelection.Size = new System.Drawing.Size(60, 13);
            this.labelEndOfSelection.TabIndex = 24;
            this.labelEndOfSelection.Text = "nextPicture";
            // 
            // labelDeleteFolder
            // 
            this.labelDeleteFolder.AutoSize = true;
            this.labelDeleteFolder.Location = new System.Drawing.Point(561, 300);
            this.labelDeleteFolder.Name = "labelDeleteFolder";
            this.labelDeleteFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDeleteFolder.Size = new System.Drawing.Size(60, 13);
            this.labelDeleteFolder.TabIndex = 25;
            this.labelDeleteFolder.Text = "nextPicture";
            // 
            // labelPushAnyButton
            // 
            this.labelPushAnyButton.AutoSize = true;
            this.labelPushAnyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPushAnyButton.Location = new System.Drawing.Point(16, 324);
            this.labelPushAnyButton.Name = "labelPushAnyButton";
            this.labelPushAnyButton.Size = new System.Drawing.Size(772, 108);
            this.labelPushAnyButton.TabIndex = 26;
            this.labelPushAnyButton.Text = "Push Any Button";
            // 
            // labelCheckForDeleteStatus
            // 
            this.labelCheckForDeleteStatus.AutoSize = true;
            this.labelCheckForDeleteStatus.Location = new System.Drawing.Point(216, 38);
            this.labelCheckForDeleteStatus.Name = "labelCheckForDeleteStatus";
            this.labelCheckForDeleteStatus.Size = new System.Drawing.Size(144, 13);
            this.labelCheckForDeleteStatus.TabIndex = 27;
            this.labelCheckForDeleteStatus.Text = "set all photo\'s status \"delete\"";
            // 
            // checkBoxForDeleteStatus
            // 
            this.checkBoxForDeleteStatus.AutoSize = true;
            this.checkBoxForDeleteStatus.Location = new System.Drawing.Point(195, 38);
            this.checkBoxForDeleteStatus.Name = "checkBoxForDeleteStatus";
            this.checkBoxForDeleteStatus.Size = new System.Drawing.Size(15, 14);
            this.checkBoxForDeleteStatus.TabIndex = 28;
            this.checkBoxForDeleteStatus.UseVisualStyleBackColor = true;
            // 
            // checkBoxDontDelete
            // 
            this.checkBoxDontDelete.AutoSize = true;
            this.checkBoxDontDelete.Location = new System.Drawing.Point(195, 63);
            this.checkBoxDontDelete.Name = "checkBoxDontDelete";
            this.checkBoxDontDelete.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDontDelete.TabIndex = 29;
            this.checkBoxDontDelete.UseVisualStyleBackColor = true;
            // 
            // labelDontDelete
            // 
            this.labelDontDelete.AutoSize = true;
            this.labelDontDelete.Location = new System.Drawing.Point(216, 63);
            this.labelDontDelete.Name = "labelDontDelete";
            this.labelDontDelete.Size = new System.Drawing.Size(81, 13);
            this.labelDontDelete.TabIndex = 30;
            this.labelDontDelete.Text = "dont delete files";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDontDelete);
            this.Controls.Add(this.checkBoxDontDelete);
            this.Controls.Add(this.checkBoxForDeleteStatus);
            this.Controls.Add(this.labelCheckForDeleteStatus);
            this.Controls.Add(this.labelPushAnyButton);
            this.Controls.Add(this.labelDeleteFolder);
            this.Controls.Add(this.labelEndOfSelection);
            this.Controls.Add(this.labelPreviousFolder);
            this.Controls.Add(this.labelNextFolder);
            this.Controls.Add(this.labelDeletePicture);
            this.Controls.Add(this.labelSavePicture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnDeleteFolder);
            this.Controls.Add(this.BtnEndOfSelection);
            this.Controls.Add(this.BtnPreviousFolder);
            this.Controls.Add(this.BtnNextFolder);
            this.Controls.Add(this.BtnDeletePicture);
            this.Controls.Add(this.BtnSavePicture);
            this.Controls.Add(this.labelPreviousPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPreviousPicture);
            this.Controls.Add(this.LabelNextPicture);
            this.Controls.Add(this.LabelNextPictureLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnFolderForSaves);
            this.Controls.Add(this.BtnToSelectFolder);
            this.Name = "FrmMain";
            this.Text = "Photo Selector";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GetButtonCode);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnToSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button BtnFolderForSaves;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelNextPictureLabel;
        private System.Windows.Forms.Label LabelNextPicture;
        private System.Windows.Forms.Button BtnPreviousPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPreviousPicture;
        private System.Windows.Forms.Button BtnSavePicture;
        private System.Windows.Forms.Button BtnDeletePicture;
        private System.Windows.Forms.Button BtnNextFolder;
        private System.Windows.Forms.Button BtnPreviousFolder;
        private System.Windows.Forms.Button BtnEndOfSelection;
        private System.Windows.Forms.Button BtnDeleteFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelSavePicture;
        private System.Windows.Forms.Label labelDeletePicture;
        private System.Windows.Forms.Label labelNextFolder;
        private System.Windows.Forms.Label labelPreviousFolder;
        private System.Windows.Forms.Label labelEndOfSelection;
        private System.Windows.Forms.Label labelDeleteFolder;
        private System.Windows.Forms.Label labelPushAnyButton;
        private System.Windows.Forms.Label labelCheckForDeleteStatus;
        private System.Windows.Forms.CheckBox checkBoxForDeleteStatus;
        private System.Windows.Forms.CheckBox checkBoxDontDelete;
        private System.Windows.Forms.Label labelDontDelete;
    }
}

