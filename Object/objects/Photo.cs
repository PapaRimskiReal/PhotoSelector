using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoSelector.Object.objects
{
    class Photo : IPhoto
    {
        private String pathToPicture;
        private EnumActions action;

        public void SetAction(EnumActions action)
        {
            this.action = action;
        }

        public EnumActions GetAction()
        {
            return action;
        }

        public String GetPicture()
        {
            return pathToPicture;
        }
        public Photo(string pathToPicture)
        {
            this.pathToPicture = pathToPicture;
            this.action = EnumActions.none;
        }

        public void Copy(String directoryOfFile, String directoryToSave, String newPhotoName)
        {
            File.Copy(directoryOfFile, directoryToSave + @"\" + System.IO.Path.GetFileName(newPhotoName), false);
        }

        public void Show(PictureBox pictureBox)
        {
            pictureBox.ImageLocation = pathToPicture;
        }

    }
}
