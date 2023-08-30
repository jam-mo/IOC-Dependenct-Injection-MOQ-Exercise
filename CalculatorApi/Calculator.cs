using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApi
{
    public class Calculator : ISimpleCalculator
    {
        private readonly IDiagnostics diag;
        private readonly IDBSave SaveToDB = null;
        
        public Calculator(IDiagnostics diagnostics, IDBSave DBSave)
        {
            this.diag = diagnostics;
            this.SaveToDB = DBSave;
        }

            public int Add(int start, int amount)
        {
            int sum = start + amount;
            string sumString = sum.ToString();
            diag.Log("Adding " + amount + " to " + start);
            SaveToDB.Save(sumString);
            return sum;
        }

        public int Subtract(int start, int amount)
        {
            int sum = start - amount;
            string sumString = sum.ToString();
            diag.Log("Subtracting " + amount + " from " + start);
            SaveToDB.Save(sumString);
            return sum;
        }

        public int Multiply(int start, int by)
        {
            int sum = start * by;
            string sumString = sum.ToString();
            diag.Log("Multiplying " + start + " by " + by);
            SaveToDB.Save(sumString);
            return sum;
        }

        public int Divide(int start, int by)
        {
            if (by == 0)
                throw new DivideByZeroException();
            int sum = start / by;
            string sumString = sum.ToString();
            diag.Log("Dividing " + start + " by " + by);
            SaveToDB.Save(sumString);
            return sum;
        }
        
    }
}
