using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProgramManager : IProgramService
    {
        IProgramDal _programDal;
        public ProgramManager(IProgramDal programDal)
        {
            _programDal = programDal;
        }
        public void Add(Program program)
        {
            _programDal.Add(program);
        }

        public void Delete(Program program)
        {
            _programDal.Delete(program);
        }

        public Program Get(int programId)
        {
            return _programDal.Get(x => x.Id == programId);
        }

        public List<Program> GetAll()
        {
            return _programDal.GetAll();
        }

        public void Update(Program program)
        {
            _programDal.Update(program);
        }
    }
}
