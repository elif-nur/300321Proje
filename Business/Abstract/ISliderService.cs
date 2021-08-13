using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISliderService
    {
        void Add(Slider slider);
        void Update(Slider slider);
        void Delete(Slider slider);
        List<Slider> GetAll();
        Slider Get(int sliderId);
    }
}
