using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.WindowsAPICodePack.Dialogs;
using PhotoSelector.Object;

namespace PhotoSelector
{
    public partial class FrmMain : Form
    {
        public static String UserSelectedFolder;
        public static String FolderToSaves = null;
        public static Boolean checkedForDelete = false;
        public static Boolean checkedDontDelete = false;
        public FrmPicture frmPicture;
        private FolderBrowserDialog folderBrowseDialog;
        private String btn;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSelectFolder(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            if (checkBoxForDeleteStatus.Checked)
            {
                checkedForDelete = true;
            }
            if (checkBoxDontDelete.Checked)
            {
                checkedDontDelete = true;
            }

            dialog.IsFolderPicker = true;
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] result = dialog.FileNames.ToArray();
                for (int i = 0; i < result.Length; i++)
                {
                    UserSelectedFolder = result[i];
                    frmPicture = new FrmPicture();
                    frmPicture.Show();
                }

            }

        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            labelPushAnyButton.Visible = false;
            SetupControls();
        }

        private void SetupControls()
        {
            LabelNextPicture.Text = FrameControls.nextPicture;
            labelPreviousPicture.Text = FrameControls.previousPicture;
            labelSavePicture.Text = FrameControls.savePicture;
            labelDeletePicture.Text = FrameControls.deletePicture;
            labelNextFolder.Text = FrameControls.nextFolder;
            labelPreviousFolder.Text = FrameControls.previousFolder;
            labelEndOfSelection.Text = FrameControls.endOfSelection;
            labelDeleteFolder.Text = FrameControls.deleteFolder;
        }

        private void BtnFolderForSaves_Click(object sender, EventArgs e)
        {
            folderBrowseDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowseDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FolderToSaves = folderBrowseDialog.SelectedPath;

            }
        }
        private void HideUserInterface()
        {
            BtnFolderForSaves.Enabled = false;
            button1.Enabled = false;
            BtnToSelectFolder.Enabled = false;
            BtnFolderForSaves.Visible = false;
            button1.Visible = false;
            BtnToSelectFolder.Visible = false;
            label1.Visible = false;
            labelDeletePicture.Visible = false;
            labelNextFolder.Visible = false;
            labelPreviousFolder.Visible = false;
            labelEndOfSelection.Visible = false;
            labelDeleteFolder.Visible = false;
            label2.Visible = false;
            labelPreviousPicture.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            labelSavePicture.Visible = false;
            LabelNextPictureLabel.Visible = false;
            LabelNextPicture.Visible = false;
            BtnDeleteFolder.Visible = false;
            BtnDeleteFolder.Enabled = false;
            BtnDeletePicture.Visible = false;
            BtnDeletePicture.Enabled = false;
            BtnPreviousPicture.Visible = false;
            BtnPreviousPicture.Enabled = false;
            BtnSavePicture.Visible = false;
            BtnSavePicture.Enabled = false;
            BtnEndOfSelection.Visible = false;
            BtnEndOfSelection.Enabled = false;
            BtnPreviousFolder.Visible = false;
            BtnPreviousFolder.Visible = false;
            labelPushAnyButton.Visible = true;
            BtnNextFolder.Enabled = false;
            BtnNextFolder.Visible = false;
            labelCheckForDeleteStatus.Visible = false;
            checkBoxForDeleteStatus.Visible = false;
            checkBoxDontDelete.Visible = false;
            labelDontDelete.Visible = false;

        }

        private void GetButtonCode(object sender, KeyEventArgs e)
        {
            
            switch (btn)
            {
                case "NextPicture": 
                    FrameControls.nextPicture = e.KeyCode.ToString();
                    break;
                case "PreviousPicture":
                    FrameControls.previousPicture = e.KeyCode.ToString();
                    break;
                case "SavePicture":
                    FrameControls.savePicture = e.KeyCode.ToString();
                    break;
                case "DeletePicture":
                    FrameControls.deletePicture = e.KeyCode.ToString();
                    break;
                case "NextFolder":
                    FrameControls.nextFolder = e.KeyCode.ToString();
                    break;
                case "PreviousFolder":
                    FrameControls.previousFolder = e.KeyCode.ToString();
                    break;
                case "EndOfSelection":
                    FrameControls.endOfSelection = e.KeyCode.ToString();
                    break;
                case "DeleteFolder":
                    FrameControls.deleteFolder= e.KeyCode.ToString();
                    break;
            }
            
            FrmMain.ActiveForm.KeyPreview = false;
            SetupControls();
            ShowUserInterface();
            
        }
        private void ShowUserInterface()
        {
            BtnFolderForSaves.Enabled = true;
            button1.Enabled = true;
            BtnToSelectFolder.Enabled = true;
            label1.Visible = true;
            labelDeletePicture.Visible = true;
            labelNextFolder.Visible = true;
            labelPreviousFolder.Visible = true;
            labelEndOfSelection.Visible = true;
            labelDeleteFolder.Visible = true;
            label2.Visible = true;
            labelPreviousPicture.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            labelSavePicture.Visible = true;
            BtnFolderForSaves.Visible = true;
            button1.Visible = true;
            BtnToSelectFolder.Visible = true;
            LabelNextPictureLabel.Visible = true;
            LabelNextPicture.Visible = true;

            BtnDeleteFolder.Visible = true;
            BtnDeleteFolder.Enabled = true;
            BtnDeletePicture.Visible = true;
            BtnDeletePicture.Enabled = true;
            BtnPreviousPicture.Visible = true;
            BtnPreviousPicture.Enabled = true;
            BtnSavePicture.Visible = true;
            BtnSavePicture.Enabled = true;
            BtnEndOfSelection.Visible = true;
            BtnEndOfSelection.Enabled = true;
            BtnPreviousFolder.Visible = true;
            BtnPreviousFolder.Enabled = true;
            BtnNextFolder.Enabled = true;
            BtnNextFolder.Visible = true;
            labelCheckForDeleteStatus.Visible = true;
            checkBoxForDeleteStatus.Visible = true;
            checkBoxDontDelete.Visible = true;
            labelDontDelete.Visible = true;

            labelPushAnyButton.Visible = false;
 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HideUserInterface();
            btn = "NextPicture";
            FrmMain.ActiveForm.KeyPreview = true;

        }
        private void BtnPreviousPicture_Click(object sender, EventArgs e)
        {
            HideUserInterface();
            btn = "PreviousPicture";
            FrmMain.ActiveForm.KeyPreview = true;
        }

        private void BtnSavePicture_Click(object sender, EventArgs e)
        {
            HideUserInterface();
            btn = "SavePicture";
            FrmMain.ActiveForm.KeyPreview = true;
        }

        private void BtnDeletePicture_Click(object sender, EventArgs e)
        {
            HideUserInterface();
            btn = "DeletePicture";
            FrmMain.ActiveForm.KeyPreview = true;
        }
        private void BtnEndOfSelection_Click(object sender, EventArgs e)
        {
            HideUserInterface();
            btn = "EndOfSelection";
            FrmMain.ActiveForm.KeyPreview = true;
        }

        private void BtnDeleteFolder_Click(object sender, EventArgs e)
        {
            HideUserInterface();
            btn = "DeleteFolder";
            FrmMain.ActiveForm.KeyPreview = true;
        }

        private void BtnNextFolder_Click_1(object sender, EventArgs e)
        {
            HideUserInterface();
            btn = "NextFolder";
            FrmMain.ActiveForm.KeyPreview = true;
        }

        private void BtnPreviousFolder_Click(object sender, EventArgs e)
        {
            HideUserInterface();
            btn = "PreviousFolder";
            FrmMain.ActiveForm.KeyPreview = true;
        }
    }
}
