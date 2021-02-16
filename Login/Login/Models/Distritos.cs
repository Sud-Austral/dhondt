using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Distritos
    {
        public string NOMBRE { get; set; }
        public int ESCANIOS { get; set; }

        public Distritos(string nOMBRE, int eSCANIOS)
        {
            NOMBRE = nOMBRE;
            ESCANIOS = eSCANIOS;
        }
    }
}