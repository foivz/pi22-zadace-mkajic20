using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOI_Equipment_Manager.Models
{
    public class Posudba
    {
        public int IdPosudbe { get; set; }
        public string Posudio { get; set; }
        public string DatumVrijeme { get; set; }
        public string Razlog { get; set; }
        public string PosudenaOprema { get; set; }


    }
}
