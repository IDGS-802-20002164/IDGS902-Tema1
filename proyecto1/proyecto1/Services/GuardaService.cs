﻿using proyecto1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace proyecto1.Services
{
    public class GuardaService
    {
        public void GuardarArchivo(Maestros maes)
        {
            var nombre = maes.Nombre;
            var apaterno = maes.Apaterno;
            var amaterno = maes.Amaterno;
            var Edad = maes.Edad;
            var Email = maes.Email;

            var datos = nombre + "," + apaterno + "," + amaterno + "," + Edad + "," + Email + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            File.AppendAllText(archivo, datos);
        }
    }
}