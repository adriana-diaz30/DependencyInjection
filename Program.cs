using System;
using System.Collections.Generic;
using System.Text;
using BusinessDemo;

IBusiness business = new BusinessV2();
UI ui = new UI(business); // inyección: BusinessV2 entra a UI por el constructor
ui.Render();
