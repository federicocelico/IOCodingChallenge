using CodingChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Models
{
    public class Cuadrado : IFormas
    {
        public decimal _lado { get ; set ; }
        public int _cantidad { get ; set ; }
        public string _nombre { get ; set ; }

        public Cuadrado()
        {
            _nombre = "SQUARE";
        }
        public decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
