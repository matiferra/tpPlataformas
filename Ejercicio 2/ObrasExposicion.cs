﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class ObrasExposicion
    {
        public ObraArte[] exposicion { get; set; }

        public ObrasExposicion(int cantObras)
        {
            exposicion = new ObraArte[cantObras];
        }

        public void insertObra(ObraArte a)
        {
            int x = 0;
            bool encontrado = false;

            while (x < exposicion.Length && encontrado == false)
            {
                if (exposicion[x] == null)
                {
                    exposicion[x] = a;
                    encontrado = true;
                }
                x++;
            }

        }

        public int cantidadObra()
        {
            int contador = 0;
            foreach (var item in exposicion)
            {
                if (item != null)
                {
                    contador++;
                }
            }

            return contador;

        }
        public bool estaLLena()
        {

            bool encontrado = true;
            int x = 0;

            while (x < exposicion.Length && encontrado == true)
            {
                if (exposicion[x] == null)
                {

                }
            }

            return encontrado;
        }

        public bool hayObras()
        {
            bool encontrado = false;
            int x = 0;

            while (x < exposicion.Length && encontrado == false)
            {
                if (exposicion[x] != null)
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        public ObraArte recuperaObra(int codigo)
        {
            ObraArte o = null;
            bool encontrado = false;
            int x = 0;
            while (x < exposicion.Length && encontrado == false)
            {
                if (exposicion[x].codigoObraArte == codigo)
                {
                    o = exposicion[x];
                    encontrado = true;
                }
            }

            return o;
        }

        public ObrasExposicion ObrasArtista(string Nom)
        {
            ObrasExposicion o = null;
            for (int i = 0; i < exposicion.Length; i++)
            {
                if (exposicion[i].nombreArtista == Nom)
                {
                    o.insertObra(exposicion[i]);
                }
            }
            return o;
        }

        public ObrasExposicion todosLosCuadrosPrestados()
        {
            ObrasExposicion o = null;
            for (int i = 0; i < exposicion.Length; i++)
            {
                if (exposicion[i] is Cuadro)
                {
                    o.insertObra(exposicion[i]);
                }

            }
            return o;
        }


}
}
