using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICardService
    {
        void Add(Card card);
        void Update(Card card);
        void Delete(Card card);
        List<Card> GetAll();
        Card Get(int cardId);
    }
}
