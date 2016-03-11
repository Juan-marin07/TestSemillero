using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedesSociales
{
    public class Facebook : IWeb
    {
        private string usuario, contrasena, direccion = "http://www.facebook.com";
        public string Url
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }

        public string Usuario
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Clave
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Ingresar()
        {
            throw new NotImplementedException();
        }
    }
}
