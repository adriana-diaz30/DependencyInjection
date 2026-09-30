using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessDemo
{
    public class UI
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
