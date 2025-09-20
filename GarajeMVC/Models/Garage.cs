namespace GarajeMVC.Models
{
    public class Garage
    {
        public int numeroGarage { get; set; }
        public string Descripcion { get; set; }
        public int capacidadEspacios { get; set; }
        public int espaciosOcupados { get; set; }

        // Atributo para almacenar una lista de autos
        public List<Auto> autos;

        public Garage(int n_numeroGarage, string n_Descripcion, int n_capacidadEspacios, int n_espaciosOcupados)
        {
            this.numeroGarage = n_numeroGarage;
            this.Descripcion = n_Descripcion;
            this.capacidadEspacios = n_capacidadEspacios;
            this.espaciosOcupados = n_espaciosOcupados;

            // Inicializamos la lista de autos
            this.autos = new List<Auto>();
        }

        public void ingresarAuto(Auto auto)
        {
            this.autos.Add(auto);
        }

        public List<Auto> getAutos()
        {
            return this.autos;
        }

        public string getDescripcion()
        {
            return this.Descripcion;
        }

    }
}
