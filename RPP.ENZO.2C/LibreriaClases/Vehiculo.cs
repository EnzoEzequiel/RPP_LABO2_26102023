using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public abstract class Vehiculo
    {
        //campos
        protected bool esAWD;
        protected Guid numeroDeChassis;
        protected EPropulsion propulsion;

        //propiedades
        public EPropulsion Propulsion { get { return this.propulsion; } }
        protected string Tipo { get; }

        protected string GetInfo()
        {
            return $"{this.Tipo} con propulsión a {this.Propulsion}, {(this.esAWD ? "es AWD" : "NO es AWD")}, numero de chasis {this.numeroDeChassis}.";
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.numeroDeChassis == v2.numeroDeChassis;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return this.GetInfo();
        }

        protected Vehiculo(EPropulsion propulsion)
        {
            this.propulsion = propulsion;
            this.numeroDeChassis = Guid.NewGuid();
            this.esAWD = false;
        }

        protected Vehiculo(EPropulsion propulsion, bool esAWD) : this(propulsion)
        {
            this.esAWD = esAWD;
        }
    }
}
