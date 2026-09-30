using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessDemo
{
    public class UI  //representa la "interfaz de usuario". No conoce a BusinessV2 directamente, solo recibe algo que cumpla IBusiness por su constructor y lo guarda en _business. Su método Render() llama a _business.DoWork() e imprime el resultado en consola.
    {
        private readonly IBusiness _business;

        public UI(IBusiness business)
        {
            _business = business;
        }

        public void Render()
        {
            System.Console.WriteLine(_business.DoWork());
        }
    }
}
