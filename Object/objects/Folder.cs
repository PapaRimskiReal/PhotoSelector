using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSelector.Object.objects
{
    class Folder : IFolder
    {
        private String directory;

        public String GetDirectory()
        {
            return directory;
        }

        public Folder(string directory)
        {
            this.directory = directory;
        }

        public string NextFolder()
        {
            throw new NotImplementedException();
        }

        public string PreviousFolder()
        {
            throw new NotImplementedException();
        }
    }


}
