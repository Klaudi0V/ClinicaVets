using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _20170404_Vets.Models
{
    public class VetsDB : DbContext
    {
        //Representar a BD descrevendo as tabelas que lá estão contidas
        // Representar o "construtor" desta class e identifica onde se encontra a BD
        public VetsDB() : base ("VetsDBConnection") {}

        //Descrever as "tabelas" que estão na BD
        public virtual DbSet<Donos> Donos { get; set; }
       
    }
}