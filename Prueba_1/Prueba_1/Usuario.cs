using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba_1
{
    [Table("Usuario")]
    internal class Usuario
    {


        [PrimaryKey]
        public int Id { get; set; }
        public string Nombre { get; set; }
        
        public string Correo { get; set; }

        public int Dni { get; set; }

        public int Num_persona { get; set; }

        public DateTime Fecha { get; set; }

        public int Num_mesa { get; set; }



        public override string ToString()
        {
            return this.Nombre + "(" + this.Correo + ")";
        }
    }
}
