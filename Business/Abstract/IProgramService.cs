using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProgramService
    {
        void Add(Program program);
        void Update(Program program);
        void Delete(Program program);
        List<Program> GetAll();
        Program Get(int programId);
    }
}
