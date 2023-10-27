namespace LibreriaClases
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public List<Vehiculo> Vehiculos { get; }

        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Fabrica(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.vehiculos.Count < fabrica.capacidad)
            {
                fabrica.vehiculos.Add(vehiculo);
            }
            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.vehiculos.Contains(vehiculo))
            {
                fabrica.vehiculos.Remove(vehiculo);
            }
            return fabrica;
        }

    }

}