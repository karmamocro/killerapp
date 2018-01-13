using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12LeerdoelenKillerApp
{
    class Setting
    {
        public static int GebruikerFk { get; private set; }
        public static int ID { get; private set; }
        public static int PasswordLength { get; private set; }
        
        public static void Create(int GebruikerFk, int ID, int PasswordLength)
        {
            Setting.GebruikerFk = GebruikerFk;
            Setting.ID = ID;
            Setting.PasswordLength = PasswordLength;
        }


    }
}
