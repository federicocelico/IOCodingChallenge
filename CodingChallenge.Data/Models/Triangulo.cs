using CodingChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Models
{
    public class Triangulo : IFormas
    {
        public decimal _lado { get ; set ; }
        public int _cantidad { get ; set ; }
        public string _nombre { get ; set ; }

        public Triangulo()
        {
            _nombre = "TRIANGLE";
        }

        public decimal CalcularArea()
        {
            return (decimal)(Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)_lado * 3;
        }
    }
}
