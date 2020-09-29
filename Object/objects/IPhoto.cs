using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoSelector.Object
{
    interface IPhoto
    {
        void Show(PictureBox pictureBox);

        void Copy(String directoryOfFile, String directoryToSave, String newPhotoName);
    }
}
