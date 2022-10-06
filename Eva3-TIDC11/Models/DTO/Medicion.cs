using System;

namespace GestionMedidores.Models.DTO
{
    public class Medicion
    {
        private int id;//Id del medidor
        private int idMedicion;
        private string tipo;  //Radio button (1: Monofasico, 2:Trifasico)
        private DateTime fecha;
        private double consumo;

        public Medicion(int v, int v1)
        {
        }

        public Medicion(int idMedidor, int idMedicion, string tipo, DateTime fecha, double consumo)
        {
            this.id = idMedidor;
            this.idMedicion = idMedicion;
            this.Tipo = tipo;
            this.fecha = fecha;
            this.consumo = consumo;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Consumo { get => consumo; set => consumo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int IdMedicion { get => idMedicion; set => idMedicion = value; }
    }
}
