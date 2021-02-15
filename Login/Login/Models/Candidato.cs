using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Candidato
    {
        public string NOMBRE { get; set; }
        public string LISTA { get; set; }
        public string PARTIDO { get; set; }
        public string  PARTIDOCORTO { get; set; }
        public string DISTRITO { get; set; }

        public Candidato(string nOMBRE, string lISTA, string pARTIDO, string pARTIDOCORTO, string dISTRITO)
        {
            NOMBRE = nOMBRE;
            LISTA = lISTA;
            PARTIDO = pARTIDO;
            PARTIDOCORTO = pARTIDOCORTO;
            DISTRITO = dISTRITO;
        }
    }
}