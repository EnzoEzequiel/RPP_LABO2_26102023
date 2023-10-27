using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Moto : Vehiculo
    {
        protected string Tipo { get; }

        public Moto(EPropulsion propulsion) : base(propulsion)
        {
            this.Tipo = "Moto";
        }
    }

}
