using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessDemo
{
    public class BusinessV2 : IBusiness // Implementación de la interfaz IBusiness, proporcionando la lógica específica para BusinessV2
                                        //implementa IBusiness. Su DoWork() simplemente devuelve el texto "BusinessV2 handling work". Es la lógica de negocio real.
    {
        public string DoWork()
        {
            return "BusinessV2 handling work";
        }
    }
}

