using GestionMedidores.Models.DTO;
using System;
using System.Collections.Generic;

namespace GestionMedidores.Models.DAL
{
    public class MedicionDAL
    {
        //Lista de medicion de los 4 medidores en 4 meses
        static List<Medicion> mediciones = new List<Medicion>
        {
            //----------(idMedidor,idMedicion,TipoMedidor,FechaMedicion,Consumo)
            new Medicion(100,1,"Monofasico",new DateTime(2022,2,10), 300.10),
            new Medicion(100,2,"Monofasico",new DateTime(2022,3,10), 400.60),
            new Medicion(100,3,"Monofasico",new DateTime(2022,4,10), 350.50),
            new Medicion(100,4,"Monofasico",new DateTime(2022,5,10), 370.30),
            new Medicion(200,5,"Monofasico",new DateTime(2022,2,10), 300.10),
            new Medicion(200,6,"Monofasico",new DateTime(2022,3,10), 400.60),
            new Medicion(200,7,"Monofasico",new DateTime(2022,4,10), 350.50),
            new Medicion(200,8,"Monofasico",new DateTime(2022,5,10), 370.30),
            new Medicion(300,9,"Trifasico",new DateTime(2022,2,10), 300.10),
            new Medicion(300,10,"Trifasico",new DateTime(2022,3,10), 400.60),
            new Medicion(300,11,"Trifasico",new DateTime(2022,4,10), 350.50),
            new Medicion(300,12,"Trifasico",new DateTime(2022,5,10), 370.30),
            new Medicion(400,13,"Trifasico",new DateTime(2022,2,10), 300.10),
            new Medicion(400,14,"Trifasico",new DateTime(2022,3,10), 400.60),
            new Medicion(400,15,"Trifasico",new DateTime(2022,4,10), 350.50),
            new Medicion(400,16,"Trifasico",new DateTime(2022,5,10), 370.30)
        };


        //Metodo retorna todas las mediciones de todos los medidores
        public List<Medicion> GetAll()
        {
            return mediciones;
        }
        
        //Metodo Retorna una lista con las mediciones de un medidor
        public List<Medicion> GetAll(string id)
        {
            if (id == "todos")
            {
                return mediciones;
            }
        List<Medicion> aux = new List<Medicion>();
            foreach(Medicion m in mediciones)
            {
                if (m.Id.ToString()==id)
                {
                    aux.Add(m);
                }
            }
            return aux;
        }

        //Elimina por id de medicion, recibe: Id de la medicion
        public void Remove(int id)
        {
            int indice=-1;
            int i = 0;
            foreach (Medicion m in mediciones) 
            {
                if (id == m.IdMedicion)
                {
                   indice=i;
                }
                i++;
            }
            mediciones.RemoveAt(indice);
        }
    }
}
