using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;
        protected string Tipo { get; }


        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Camioneta"/> con los valores especificados.
        /// </summary>
        /// <param name="propulsion">El tipo de propulsion del vehiculo que paso POR PARAMETRO.</param>
        /// <param name="cabinaSimple">Indica si la camioneta tiene cabina simple.</param>
        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(propulsion)
        {
            this.cabinaSimple = cabinaSimple;
            this.Tipo = "Camioneta";
        }

        protected string GetInfo()
        {
            return $"Tipo: {this.Tipo}, Propulsion: {this.Propulsion}, Cabina Simple: {this.cabinaSimple}";
        }
    }
}
