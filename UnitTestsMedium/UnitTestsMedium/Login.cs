using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsMedium
{
    public class Login 
    {
        private readonly IDatabaseRetriever _databaseRetriver;

        public Login(IDatabaseRetriever databaseRetriver)
        {
            _databaseRetriver = databaseRetriver;
        }

        public bool Authenticate(string username, string suppliedHash)
        {
            var storedHash = _databaseRetriver.RetrievePassword(username);

            if (storedHash == suppliedHash)
                return true;

            else
                return false;
            
        }
    }
}
