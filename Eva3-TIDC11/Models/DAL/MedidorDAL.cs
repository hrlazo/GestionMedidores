using GestionMedidores.Models.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace GestionMedidores.Models.DAL
{
    public class MedidorDAL
    {
        //Lista de medidores
        static List<Medidor> medidores = new List<Medidor> 
        { 
            new Medidor(100,"Monofasico"),
            new Medidor(200,"Monofasico"),
            new Medidor(300,"Trifasico"),
            new Medidor(400,"Trifasico"),
        };

        //Lista de los medidores para filtro
            static List<SelectListItem> medidoresParaFiltro = new List<SelectListItem>
        {
            new SelectListItem{Text ="Todos", Value="todos"},
            new SelectListItem{Text ="100", Value="100"},
            new SelectListItem{Text ="200", Value="200"},
            new SelectListItem{Text ="300", Value="300"},
            new SelectListItem{Text ="400", Value="400"}
        };

        //Retorna la lista de los medidores para usar de filtro
        public List<SelectListItem> obtenerMedidoresFiltrados()
        {
            return medidoresParaFiltro;
        }

        //Agregamos el medidor a la lista de SelectListItem
        public void AgregarMedidorParaFiltro(string id) 
        {
            medidoresParaFiltro.Add(new SelectListItem(id,id));
        }

        //Metodo para agregar medidores
        public void Add(Medidor m)
        {
            medidores.Add(m);
        }
        
        //Metodo para retornar todos los medidores
        public List<Medidor> GetAll() 
        { 
            return medidores; 
        }
        public bool ExisteMedidor(int id) 
        {
            foreach(Medidor m in medidores) 
            {
                if (m.Id == id) return true;
            }
            return false;
        }

        //Metodo para retornar una Lista de medidores de acuerdo al tipo
        public List<Medidor> GetAll(string tipo) 
        {
            if (tipo=="todos") 
            {
                return medidores;
            }
            List<Medidor> aux = new List<Medidor>();
            foreach (Medidor m in medidores)
            {
                if (m.Tipo.ToLower() == tipo.ToLower())
                {
                    aux.Add(m);
                }
            }
            return aux;
        }
    }
}
