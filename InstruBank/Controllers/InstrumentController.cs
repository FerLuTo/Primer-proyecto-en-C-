using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstruBank.Models;
using InstruBank.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Instrument_Bank.Controllers
{
    public class InstrumentController : Controller
    {
        private readonly DbInstrumentContext context;
        public InstrumentController(DbInstrumentContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Instrument> lista = context.Instruments.ToList();
            return View(lista);
        }

        //Get /instrument/create
        public IActionResult Create()
        {
            Instrument instrumento = new Instrument();
            return View(instrumento);
        }

        //Post  /instrument/create

        [HttpPost]
        public IActionResult Create(Instrument instrumento)
        {
            if (ModelState.IsValid)
            {
                context.Instruments.Add(instrumento);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", "Instrument");
            }

        }


        public IActionResult FindByName()
        {
            return View();
        }
        [Route("Instrument/FindByName/{nombre?}")]
        [HttpPost]
        public IActionResult FindByName(string nombre)
        { 
            if (nombre == null)
            {
                return RedirectToAction("Index");
            }

            List<Instrument> instruments = (from i in context.Instruments 
                                             where i.Nombre == nombre 
                                             select i 
                                        ).ToList();

            return View("Index",instruments);

        }


        //Get 
        [Route("Instrument/Delete")]
        public IActionResult Delete(int id)
        {
            Instrument instrumento = context.Instruments.Find(id);
            if (instrumento == null)
            {
                return NotFound();
            }
            else
            {
                context.Instruments.Remove(instrumento);
                context.SaveChanges();
                
            }
            return RedirectToAction("Index");
        }

        //Get  
        
        public IActionResult Edit(int id)
        {
            Instrument instrumento = context.Instruments.Find(id);
            if (instrumento == null)
            {
                return NotFound();
            }
            return View(instrumento);

        }

        //Post
        [HttpPost]
        public IActionResult Edit(int id,Instrument instru1)
        {
            Instrument instrumento = context.Instruments.Find(id);
            if (instrumento != null)
            {
                instrumento.Nombre = instru1.Nombre;
                instrumento.Tipo = instru1.Tipo;
                instrumento.Marca = instru1.Marca;
                instrumento.Precio = instru1.Precio;
                instrumento.Stock = instru1.Stock;
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            
            return NotFound();
            




        }



    }
}

