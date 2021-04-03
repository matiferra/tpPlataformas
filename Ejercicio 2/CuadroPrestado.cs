﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{ 
    class CuadroPrestado : Cuadro
    {

        public DateTime fechaDevolucion { get; set; }
        public string nombreGaleria { get; set; }

        public CuadroPrestado(DateTime fechaDevolucion, string nombreGaleria, double Base, double altura, string nombre, string nombreArtista, int anioCreacion, DateTime fechaIngreso)
            : base(Base, altura, nombre, nombreArtista, anioCreacion, fechaIngreso)
        {
            this.fechaDevolucion = fechaDevolucion;
            this.nombreGaleria = nombreGaleria;

        }

    }
}
