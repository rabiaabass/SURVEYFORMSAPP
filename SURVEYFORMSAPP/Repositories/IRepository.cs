using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SURVEYFORMSAPP.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> GetData();
    }
}
