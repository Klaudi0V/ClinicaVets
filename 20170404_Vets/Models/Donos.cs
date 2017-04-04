using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20170404_Vets.Models
{
    public class Donos
    {
        public int DonosID {get; set;}

        public string Nome { set; get; }

        public string Morada { set; get; }

        public string CodPostal { set; get; }

        public string NIF { get; set; }

        public double Altura { set; get; }

        public int Idade { set; get; }
    }
}