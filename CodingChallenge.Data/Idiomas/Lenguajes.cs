using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace CodingChallenge.Data.Idiomas
{
    public class Lenguajes
    {
        private Lenguaje lenguaje = Lenguaje.ENGLISH;
        private ResourceManager resManager;

        public Lenguaje Idioma
        {
            get { return lenguaje; }
        }

        public string ObtenerLinea(string key, params object[] args)
        {
            return string.Format(resManager.GetString(key), args);
        }

        public Lenguajes(Lenguaje lenguaje)
        {
            switch (lenguaje)
            {
                case Lenguaje.ENGLISH:
                    {
                        resManager = en.ResourceManager;
                        break;
                    }
                case Lenguaje.CASTELLANO:
                    {
                        resManager = es.ResourceManager;
                        break;
                    }
                default:
                    {
                        resManager = en.ResourceManager;
                        break;
                    }
            }
            this.lenguaje = lenguaje;
        }

    }

    public enum Lenguaje
    {
        CASTELLANO = 1,
        ENGLISH = 2
    }
}
