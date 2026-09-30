using System;
using System.Collections.Generic;
using System.Text;
using BusinessDemo;

IBusiness business = new BusinessV2();   // 1. crea la implementación concreta
UI ui = new UI(business);                // 2. la inyecta en la UI
ui.Render();                             // 3. la UI la usa sin saber que es BusinessV2



//Al ejecutarlo, esto imprime en consola:
//BusinessV2 handling work