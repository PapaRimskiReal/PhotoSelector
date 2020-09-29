using PhotoSelector.Object.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using PhotoSelector.Object;

namespace PhotoSelector
{
    public partial class FrmPicture : Form
    {
        private Folder currentSubFolder;
        private String mainFolderNew;
        private String subFolderNew;
        private String deleteFolder;
        private List<String> subFoldersList;
        private Photo photo;
        private int currentPictureIndex;
        private int currentFolderIndex;
        private List<Photo> listOfPhoto;
        private String folderToSaves = @"C:\PicsDone";
        // 


        public FrmPicture()
        {
            InitializeComponent();
        }
        private void FrmPicture_Load(object sender, EventArgs e)
        {
            
            
            if (FrmMain.FolderToSaves != null)
            {
                folderToSaves = FrmMain.FolderToSaves;
            }

            subFoldersList = Directory.GetDirectories(FrmMain.UserSelectedFolder).ToList();
            subFoldersList = CheckForExtraDirectoriesInFolderList(subFoldersList);            
            currentFolderIndex = 0;
            listOfPhoto = new List<Photo>();
            StartFolderWork();

        }
        //subfolder witch at least one folder inside do not add to list
        private List<string> CheckForExtraDirectoriesInFolderList(List<string> foldersList)
        {
            List<int> badnumbers = new List<int>();
            for (int i = 0; i < foldersList.Count(); i++)
            {
                DirectoryInfo di = Directory.CreateDirectory(foldersList[i]);
                DirectoryInfo[] subdirs = di.GetDirectories();
                
                if (subdirs.Length > 0)
                {
                   badnumbers.Add(i);
                }
            }
            /*badnumbers.ForEach(x => MessageBox.Show(x.ToString()));
            MessageBox.Show(badnumbers.Count().ToString());*/
            for (int i = 0; i < badnumbers.Count(); i++)
            {
                foldersList.RemoveAt(badnumbers[i] - i);
            }

            return foldersList;
        }
        private void StartFolderWork()
        {
            if (CheckFolderIsNotEmpty())
            {
                SetCurrentDirectory(currentFolderIndex);
                FillPhotosList();
                ShowPicture();
            }
            else MessageBox.Show("Folder is empty");
        }
        private bool CheckFolderIsNotEmpty()
        {
            if (subFoldersList.Count() == 0) {
               
                return false;
            }
            return true;
        }
        private void FillPhotosList()
        {
            String[] photosInDirectory = Directory.GetFiles(currentSubFolder.GetDirectory());
            listOfPhoto.Clear();
            
            Photo temp;
            for (int i = 0; i < photosInDirectory.Length; i++)
            {
                temp = new Photo(photosInDirectory[i]);
                
                if (FrmMain.checkedForDelete)
                {
                    temp.SetAction(EnumActions.delete);
                }
                
                listOfPhoto.Add(temp);


            }
             currentPictureIndex = 0;
        }
        private void SetCurrentDirectory(int indexOfFolder)
        {
            currentSubFolder = new Folder(subFoldersList[indexOfFolder]);
           
        }
        private void ShowPicture()
        {
            ShowPhotoInfo(listOfPhoto[currentPictureIndex]);
            listOfPhoto[currentPictureIndex].Show(BoxPicture);
            
        }
        private void ShowPhotoInfo(Photo picture)
        {

            FrmPicture.ActiveForm.Text = string.Format("{0} / {1} - {2}          folder name:   {3}  ===>  {4}         folder count:   {5} / {6}",
                currentPictureIndex + 1,
                listOfPhoto.Count(),
                picture.GetAction(),
                Path.GetFileName(subFoldersList[currentFolderIndex]),
                Path.GetFileName(subFoldersList[MaybeEndOfFolderList(currentFolderIndex)]),
                currentFolderIndex+1,
                subFoldersList.Count());
          
        }
        private void NextPicture()
        {
            currentPictureIndex++;
            if (currentPictureIndex > (listOfPhoto.Count() - 1))
            {
                currentPictureIndex = 0;

            }
            ShowPicture(); 
            
        }
        private void PreviousPicture()
                {
                    currentPictureIndex--;
                    if (currentPictureIndex < 0)
                    {
                        currentPictureIndex = listOfPhoto.Count() - 1;
               
                    }
                     ShowPicture();
            
                }
        private void DeleteDirectory()
        {
            deleteFolder = subFoldersList[currentFolderIndex];
            currentSubFolder = null;
            photo = null;
            listOfPhoto.Clear();
            
            DirectoryInfo dir = new System.IO.DirectoryInfo(deleteFolder);
            SetAttributesNormal(dir);
            BoxPicture.ImageLocation = null;
            
            if (dir.Exists)
                /*dir.Delete(true);*/
               (dir.ToString()).DirectoryRecycle();

            subFoldersList.RemoveAt(currentFolderIndex);
            
            StartFolderWork();

        }
        private void SetAttributesNormal(DirectoryInfo path)
        {
            // BFS folder permissions normalizer
            Queue<DirectoryInfo> dirs = new Queue<DirectoryInfo>();
            dirs.Enqueue(path);
            while (dirs.Count > 0)
            {
                var dir = dirs.Dequeue();
                dir.Attributes = FileAttributes.Normal;
                Parallel.ForEach(dir.EnumerateFiles(), e => e.Attributes = FileAttributes.Normal);
                foreach (var subDir in dir.GetDirectories())
                    dirs.Enqueue(subDir);
            }
        }
        private void GreateMainFolder()
        {
            
            mainFolderNew = folderToSaves + @"\" + Path.GetFileName(Path.GetDirectoryName(subFoldersList[currentFolderIndex]));

            if (Directory.Exists(mainFolderNew))
            {
            } else
            {
                DirectoryInfo newMainFolder = Directory.CreateDirectory(mainFolderNew);
            } 
        }
        private void GreateFolderForSaves()
        {
            int count = 2; 
            subFolderNew = mainFolderNew + @"\" + Path.GetFileName(Path.GetDirectoryName(photo.GetPicture()));

            while (Directory.Exists(subFolderNew))
            {
                subFolderNew = subFolderNew + " " + count;
                count++;
            }
            /*  if (Directory.Exists(subFolderNew)) {


              } else {
                  DirectoryInfo newSubFolder = Directory.CreateDirectory(subFolderNew);
              }*/
            DirectoryInfo newSubFolder = Directory.CreateDirectory(subFolderNew);

        }
        private void CopyPhoto()
        {
            int photoCounter = 0;
            foreach (Photo ph in listOfPhoto)
            {
                if (ph.GetAction() == EnumActions.copy)
                {
                    photoCounter++;
                    ph.Copy(ph.GetPicture(), subFolderNew, System.IO.Path.GetFileName(subFolderNew).
                                                                ToString() 
                                                                + " " 
                                                                + photoCounter 
                                                                + Path.GetExtension(ph.GetPicture()));
                }
            }
        }
        private bool CheckPicturesForNoneAction()
        {
            foreach (Photo ph in listOfPhoto)
            {
                if (ph.GetAction().Equals(EnumActions.none))
                {
                    return false;
                }

            }
            return true;
        }
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            
            photo = listOfPhoto[currentPictureIndex];
            if (e.KeyCode.ToString() == FrameControls.nextPicture)
            {
                NextPicture();

            } else if (e.KeyCode.ToString() == FrameControls.previousPicture)
            {
                PreviousPicture();
            }
            else if (e.KeyCode.ToString() == FrameControls.savePicture)
            {
                photo.SetAction(EnumActions.copy);
                NextPicture();
            }
            else if (e.KeyCode.ToString() == FrameControls.deletePicture)
            {
                photo.SetAction(EnumActions.delete);
                NextPicture();
            }
            else if (e.KeyCode.ToString() == FrameControls.nextFolder)
            {
                NextFolder();
            }
            else if (e.KeyCode.ToString() == FrameControls.previousFolder)
            {
                PreviousFolder();
            }
            else if (e.KeyCode.ToString() == FrameControls.endOfSelection)
            {
                if (FrmMain.checkedDontDelete) {
                    EndOfFolderSelectionDontDelete();
                } else EndOfFolderSelection();
            }
            else if (e.KeyCode.ToString() == FrameControls.deleteFolder)
            {
                DeleteDirectory();
            }

            /*   switch (e.KeyCode)
               {

                   case Keys.Right:
                       NextPicture();
                       break;
                   case Keys.Left:
                       PreviousPicture();
                       break;
                   case Keys.Up:
                       photo.SetAction(EnumActions.copy);
                       NextPicture();
                       break;
                   case Keys.Down:
                       photo.SetAction(EnumActions.delete);
                       NextPicture();
                       break;
                   case Keys.M:
                       NextFolder();
                       break;
                   case Keys.N:
                       PreviousFolder();
                       break;
                   case Keys.Enter:
                       EndOfFolderSelection();
                       break;
                   case Keys.Delete:
                       DeleteDirectory();
                       break;
               }*/

        }
        private void EndOfFolderSelection()
        {
            if (CheckPicturesForNoneAction())
            {
                GreateMainFolder();
                GreateFolderForSaves();
                CopyPhoto();
                DeleteDirectory();
            }
            else
            {

                List<int> numbersList = new List<int>();
                for (int i = 0; i < listOfPhoto.Count(); i++)
                {
                    if (listOfPhoto[i].GetAction() == EnumActions.none)
                    {
                        numbersList.Add(i + 1);
                    }
                }
                string numberOfNone = string.Join(" ", numbersList.ToArray());
                MessageBox.Show("Photos with none action status: " + numberOfNone + " (should be save or delete)");
            }
        }
        private void EndOfFolderSelectionDontDelete()
        {
            GreateMainFolder();
            GreateFolderForSaves();
            CopyPhoto();
            MessageBox.Show("Copied");
        }
        private void NextFolder()
        {
            currentFolderIndex = MaybeEndOfFolderList(currentFolderIndex);
            
            StartFolderWork();
        }
        private int MaybeEndOfFolderList(int index)
        {
            index++;
            if (index > subFoldersList.Count() - 1)
            {
                index = 0;
                return index;
            }
            return index;
        }
        private void PreviousFolder()
        {
            currentFolderIndex = MaybeBeginOfFolderList(currentFolderIndex);
            
            StartFolderWork();
        }
        private int MaybeBeginOfFolderList(int index)
        {
            index--;
            if (index < 0)
            {
                index = subFoldersList.Count() - 1;
                return index;
            }
            return index;
        }

    }
}
