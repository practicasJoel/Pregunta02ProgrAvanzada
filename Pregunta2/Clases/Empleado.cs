using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pregunta2.Model;
using Pregunta2.Clases;

namespace Pregunta2.Clases
{
    public class Empleado
    {
        Caso01Entities db = new Caso01Entities();

        public List<Empleado> mostrarEmpleado()
        {
            return db.empleado.ToList();

        }

    }
}