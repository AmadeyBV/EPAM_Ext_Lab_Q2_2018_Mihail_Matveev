using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTS
{
    public abstract class User : CommonFeatures
    {
        public int ID;
        public string FirstName;
        public string SecondName;
        public string Position;
        public int Password;
    }
}