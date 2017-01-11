using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsMedium
{
    public interface IDatabaseRetriever
    {
        string RetrievePassword(string username);
    }

    public class DatabaseRetriever : IDatabaseRetriever
    {
        public string RetrievePassword(string username)
        {
            throw new NotImplementedException();
        }
    }
}
