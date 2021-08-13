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
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void Add(Slider slider)
        {
            _sliderDal.Add(slider);
        }

        public void Delete(Slider slider)
        {
            _sliderDal.Delete(slider);
        }

        public Slider Get(int sliderId)
        {
            return _sliderDal.Get(x => x.Id == sliderId);
        }

        public List<Slider> GetAll()
        {
            return _sliderDal.GetAll();
        }

        public void Update(Slider slider)
        {
            _sliderDal.Update(slider);
        }
    }
}
