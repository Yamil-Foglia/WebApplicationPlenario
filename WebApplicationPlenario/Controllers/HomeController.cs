using Plenario.Core;
using Plenario.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationPlenario.Controllers
{
    public class HomeController : Controller
    {
        private PlenarioEntities mainContext = new PlenarioEntities();
        public ActionResult Index()
        {
            return View();
        }

        #region PersonaAdd
        public ActionResult PersonaAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PersonaAdd(string nombre, string apellido, DateTime fechaDeNacimiento, string creditoMaximo)
        {
            var nuevaPersona = new Persona();
            nuevaPersona.Nombre = nombre + " " + apellido;
            nuevaPersona.FechaNacimiento = fechaDeNacimiento;
            nuevaPersona.CreditoMaximo = decimal.Parse(creditoMaximo);
            
            this.mainContext.Persona.Add(nuevaPersona);

            this.mainContext.SaveChanges();

            return Redirect("/Home/PersonaList");
        }

        #endregion

        #region PersonaModify
        public ActionResult PersonaModify(int id)
        {
            var persona = this.mainContext.Persona.ToList().Where(x => x.PersonaID == id).FirstOrDefault();

            persona.PersonaID = id;
            return View(persona);
        }

        [HttpPost]
        public ActionResult PersonaModify(int personaID, string nombre, DateTime fechaDeNacimiento, string creditoMaximo)
        {
            var personaModicada = this.mainContext.Persona.ToList().Where(x => x.PersonaID == personaID).FirstOrDefault();

            personaModicada.Nombre = nombre;
            personaModicada.FechaNacimiento = fechaDeNacimiento;
            personaModicada.CreditoMaximo = decimal.Parse(creditoMaximo);

            this.mainContext.Entry(personaModicada).State = System.Data.Entity.EntityState.Modified;
            this.mainContext.SaveChanges();

            return Redirect("/Home/PersonaList");
        }
        #endregion

        #region PersonaList
        public ActionResult PersonaList()
        {
            return View(this.mainContext.Persona.ToList());
        }

        [HttpPost]
        public ActionResult PersonaList(string nombreBusado)
        {
            var personas = this.mainContext.Persona.ToList().Where(x => x.Nombre.ToLower() == nombreBusado.ToLower());

            return View("PersonaList", personas.ToList());
        }
        #endregion

        #region PersonaDelete
        public ActionResult PersonaDelete(int id)
        {
            var persona = this.mainContext.Persona.ToList().Where(x => x.PersonaID == id).FirstOrDefault();

            return View(persona);
        }

        [HttpPost]
        public ActionResult PersonaDelete(int id, FormCollection collection)
        {
            var persona = this.mainContext.Persona.ToList().Where(x => x.PersonaID == id).FirstOrDefault();

            ViewBag.Message = String.Format("Hello{0}", DateTime.Now.ToString());


            this.mainContext.Persona.Remove(persona);

            this.mainContext.SaveChanges();

            return Redirect("/Home/PersonaList");
        }
        #endregion

        #region TelefonoAdd
        public ActionResult TelefonoAdd()
        {
            var nuevoTelefono = new Telefono();
            nuevoTelefono.PersonaID = Data.PersonaID;

            return View(nuevoTelefono);
        }

        [HttpPost]
        public ActionResult TelefonoAdd(string numeroDeTelefono)
        {
            var nuevoTelefono = new Telefono();

            nuevoTelefono.PersonaID = Data.PersonaID;
            nuevoTelefono.Telefono1 = numeroDeTelefono;

            this.mainContext.Telefono.Add(nuevoTelefono);

            this.mainContext.SaveChanges();

            var telefonos = this.mainContext.Telefono.ToList().Where(x => x.PersonaID == Data.PersonaID);

            return View("TelefonoList", telefonos);
        }

        #endregion

        #region TelefonoModify
        public ActionResult TelefonoModify(int id)
        {
            var telefono = this.mainContext.Telefono.ToList().Where(x => x.TelefonoID == id).FirstOrDefault();

            telefono.TelefonoID = id;
            return View(telefono);
        }

        [HttpPost]
        public ActionResult TelefonoModify(int telefonoID, string numeroDeTelefono)
        {

            var telefonoModicado = this.mainContext.Telefono.ToList().Where(x => x.TelefonoID == telefonoID).FirstOrDefault();

            telefonoModicado.Telefono1 = numeroDeTelefono;

            this.mainContext.Entry(telefonoModicado).State = System.Data.Entity.EntityState.Modified;
            this.mainContext.SaveChanges();

            var telefonos = this.mainContext.Telefono.ToList().Where(x => x.PersonaID == Data.PersonaID);

            return View("TelefonoList", telefonos);
        }
        #endregion

        #region TelefonoDelete
            public ActionResult TelefonoDelete(int id)
        {
            var telefono = this.mainContext.Telefono.ToList().Where(x => x.TelefonoID == id).FirstOrDefault();

            return View(telefono);
        }

        [HttpPost]
        public ActionResult TelefonoDelete(int id, FormCollection collection)
        {
            var telefono = this.mainContext.Telefono.ToList().Where(x => x.TelefonoID == id).FirstOrDefault();

            this.mainContext.Telefono.Remove(telefono);

            this.mainContext.SaveChanges();

            var telefonos = this.mainContext.Telefono.ToList().Where(x => x.PersonaID == Data.PersonaID);

            return View("TelefonoList", telefonos);
        }

        #endregion

        #region TelefonoList
        public ActionResult TelefonoList(int id)
        {
            var telefonos = this.mainContext.Telefono.ToList().Where(x => x.PersonaID == id);
            Data.PersonaID = id;

            return View(telefonos);
        }

        #endregion

    }
}
