using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Automovil : Vehiculo
    {
        protected string Tipo { get; }

        public Automovil() : base(EPropulsion.hibrida)
        {
            this.Tipo = "Automovil";
        }
    }

}
