using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessDemo  //cualquier clase que lo implemente debe tener un método DoWork() que devuelve un string. No tiene lógica propia.
{
    public interface IBusiness
    {
        string DoWork();
    }
}

