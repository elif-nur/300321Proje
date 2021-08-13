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
    public class CardManager : ICardService
    {
        ICardDal _cardDal;

        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }

        public void Add(Card card)
        {
            _cardDal.Add(card);
        }

        public void Delete(Card card)
        {
            _cardDal.Delete(card);
        }

        public Card Get(int cardId)
        {
            return _cardDal.Get(x => x.Id == cardId);
        }

        public List<Card> GetAll()
        {
            return _cardDal.GetAll();
        }

        public void Update(Card card)
        {
            _cardDal.Update(card);
        }
    }
}
