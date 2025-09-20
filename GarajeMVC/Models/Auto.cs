namespace GarajeMVC.Models
{
    public class Auto
    {

        public int numeroAuto { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }

        public Auto(int n_numeroAuto, string n_Marca, string n_Placa)
        {
            this.numeroAuto = n_numeroAuto;
            this.Marca = n_Marca;
            this.Placa = n_Placa;
        }

    }
}
