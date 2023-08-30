using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorApi
{
    public class DBSave : IDBSave
    {
        public void Save(string message)
        {
            using (var dbContext = new CalcDBModel())
            {
                dbContext.CalcTables.Add(new CalcTable { LoggingString = message });
                dbContext.SaveChanges();
            }
        }

        // Stored Procedure
        public void Read()
        {
            
        }
       


    }
}
