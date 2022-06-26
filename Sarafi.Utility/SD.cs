using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarafi.Utility
{
    public class SD
    {
        public const string Role_admin = "admin";
        public const string Role_Changer = "Changer";

        //this field gets initialized at Startup.cs
        public static string Connectionstring;
        public static string GetConnection { get { return Connectionstring; } }



    }
}
