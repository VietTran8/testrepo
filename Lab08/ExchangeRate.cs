using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    internal class ExchangeRate
    {
        public string Symbol { get; set; }
        public double Rate { get; set; }
        public ExchangeRate(string Symbol, double Rate) {
            this.Symbol = Symbol;
            this.Rate = Rate;
        }
    }
}
