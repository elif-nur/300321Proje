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
    public class RuleManager : IRuleService
    {
        IRuleDal _ruleDal;

        public RuleManager(IRuleDal ruleDal)
        {
            _ruleDal = ruleDal;
        }

        public void Add(Rule rule)
        {
            _ruleDal.Add(rule);
        }

        public void Delete(Rule rule)
        {
            _ruleDal.Delete(rule);
        }

        public Rule Get(int ruleId)
        {
            return _ruleDal.Get(x => x.Id == ruleId);
        }

        public List<Rule> GetAll()
        {
            return _ruleDal.GetAll();
        }

        public void Update(Rule rule)
        {
            _ruleDal.Update(rule);
        }
    }
}
