using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWritingService
    {
        void Add(Writing writing);
        void Update(Writing writing);
        void Delete(Writing writing);
        List<Writing> GetAll();
        Writing Get(int writingId);
    }
}
