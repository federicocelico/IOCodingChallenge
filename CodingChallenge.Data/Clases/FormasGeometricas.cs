using CodingChallenge.Data.Idiomas;
using CodingChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Clases
{
    public class FormasGeometricas
    {
        private static Lenguajes lenguajes;
        public static string Imprimir(List<IFormas> formas, Lenguaje lenguaje)
        {
            lenguajes = new Lenguajes(lenguaje);

            var sb = new StringBuilder();

           
            if(!formas.Any())
            { //Header
                sb.AppendLine(lenguajes.ObtenerLinea("EMPTY"));
            }
            else
            { //Header
                sb.AppendLine(lenguajes.ObtenerLinea("NOT-EMPTY"));
                decimal totArea = 0;
                decimal totPerimetro = 0;

                //Body
                foreach (IFormas forma in formas)
                {

                    sb.AppendLine(lenguajes.ObtenerLinea("INFO", forma._cantidad + " ", lenguajes.ObtenerLinea((forma._cantidad > 1) ? forma._nombre + "-PL" : forma._nombre), forma.CalcularArea().ToString("#.##"), forma.CalcularPerimetro().ToString("#.##")));
                    totArea += forma.CalcularArea();
                    totPerimetro += forma.CalcularPerimetro();
                }

                // FOOTER
                sb.Append(lenguajes.ObtenerLinea("TOTAL"));
                sb.AppendLine(lenguajes.ObtenerLinea((formas.Count > 1 ? "TOTAL-SHAPES-PL" : "TOTAL-SHAPES"), formas.Count));
                sb.AppendLine(lenguajes.ObtenerLinea("TOTAL-AREA", totArea.ToString("#.##")));
                sb.Append(lenguajes.ObtenerLinea("TOTAL-PERIMETER", totPerimetro.ToString("#.##")));
            }
            return sb.ToString();
        }
    }
}
