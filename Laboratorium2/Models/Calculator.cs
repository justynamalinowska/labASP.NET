using System.Data.Common;

namespace Laboratorium2.Models
{
    public class Calculator
    {
        public Operators? Operator { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public string Op
        {
            get => operatorsSymbols[Operator ?? Operators.Add];
        }

        private Dictionary<Operators, string> operatorsSymbols = new Dictionary<Operators, string>()
        {
            { Operators.Add, "+" },
            { Operators.Mul, "×" },
            { Operators.Sub, "-" },
            { Operators.Div, "÷" }
        };

        public bool IsValid()
        {
            return Operator != null && X != null && Y != null;
        }

        public double Calculate()
        {
            switch (Operator)
            {
                case Operators.Add:
                    return (double)(X + Y);
                case Operators.Sub:
                    return (double)(X - Y);
                case Operators.Mul:
                    return (double)(X * Y);
                case Operators.Div:
                    return (double)(X / Y);
            }

            return 0;
        }
    }
}
