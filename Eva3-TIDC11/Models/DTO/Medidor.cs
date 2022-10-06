namespace GestionMedidores.Models.DTO
{
    public class Medidor
    {
       //Attributes
        private int id;
        private string tipo;  //Radio button (1: Monofasico, 2:Trifasico)

        //Constructor Vacio
        public Medidor(){}

        //Constructor
        public Medidor(int id, string tipo)
        {
            this.id = id;
            this.Tipo = tipo;
        }

        //Getters and Setters
        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
