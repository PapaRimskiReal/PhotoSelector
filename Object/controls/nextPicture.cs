using PhotoSelector.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSelector
{
    class NextPicture : ButtonAction
    {
        public override string getAction()
        {
            return FrameControls.nextPicture;
        }
    };
   
}
