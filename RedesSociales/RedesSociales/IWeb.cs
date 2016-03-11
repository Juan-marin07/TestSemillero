using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedesSociales
{
    public interface IWeb
    {
        string Url
        {
            get;
            set;
        }

        string Usuario
        {
            get;
            set;
        }

        string Clave
        {
            get;
            set;
        }
    
        void Ingresar();
    }
}
