using GestionMedidores.Models.DAL;
using GestionMedidores.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eva3_TIDC11.Controllers
{
    public class MedidorController : Controller
    {
        MedidorDAL medidoresDAL = new MedidorDAL();
        MedicionDAL medicionDAL = new MedicionDAL();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        // GET: Formulario para nuevo medidor
        public ActionResult Agregar()
        {
            return View();
        }

        //POST: Datos del nuevo medidor a crear
        [HttpPost]
        public ActionResult Agregar(int id, string tipo)
        {
            //Comprobamos si el id ya esta dentro de la base de datos

            if (medidoresDAL.ExisteMedidor(id))
            {
                ViewData["msjConfirmacion"] = "Ya existe un medidor con ese codigo";
                return View();
            }
            else if (tipo is null)
            {
                ViewData["msjConfirmacion"] = "Elegir tipo de Medidor";
                return View();
            }
            //Comprobar que el codigo no existe en la BD
            Medidor m = new Medidor();
            m.Id = id;
            m.Tipo = tipo;
            medidoresDAL.Add(m);
            medidoresDAL.AgregarMedidorParaFiltro(id.ToString());
            ViewData["msjConfirmacion"] = "Medidor Registrado";
            return View();
        }

        //GET: Lista de todos los medidores
        public ActionResult ListarMedidores()
        {
            ViewData["medidores"] = medidoresDAL.GetAll();
            return View();
        }

        //POST: Listar los medidores por eleccion del DropDownList
        [HttpPost]
        public ActionResult ListarMedidores(string tipo)
        {
            //Leer la opcion que quedo seleccionada en el select
            //Filtramos y enviamos la lista de medidores que cumplen con el tipo
            ViewData["medidores"] = medidoresDAL.GetAll(tipo);
            return View();
        }
        // GET: MedicionController
        public ActionResult ListarMediciones()
        {
            ViewData["mediciones"] = medicionDAL.GetAll();
            return View();
        }
        //POST: Listar las mediciones de acuerdo al medidor seleccionado del dropdown
        [HttpPost]
        public ActionResult ListarMediciones(string tipo)
        {
            ViewData["mediciones"] = medicionDAL.GetAll(tipo);
            return View();
        }

        //Eliminamos una Medicion en especifico
        public IActionResult EliminarMedicion(int id)
        {
            medicionDAL.Remove(id);
            return Redirect("~/Medidor/ListarMediciones");
        }
    }
}
