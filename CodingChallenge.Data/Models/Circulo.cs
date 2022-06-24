using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Models
{
    public class Circulo : IFormas
    {
        public decimal _lado { get; set; }
        public int _cantidad { get; set; }
        public string _nombre { get; set ; }

        public Circulo()
        {
            _nombre = "CIRCLE";
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }
    }
}
