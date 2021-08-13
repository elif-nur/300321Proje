using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IScientificService
    {
        void Add(Scientific scientific);
        void Update(Scientific scientific);
        void Delete(Scientific scientific);
        List<Scientific> GetAll();
        Scientific Get(int scientificId);
    }
}
