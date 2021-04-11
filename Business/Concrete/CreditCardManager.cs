using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCarDal _creditCardDal;

        public CreditCardManager(ICreditCarDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        [SecuredOperation("user")]
        public IResult Add(CreditCard creditCard)
        {
            _creditCardDal.Add(creditCard);
            return new SuccessResult(Messages.cretidCarAdded);
        }

        [SecuredOperation("user")]
        public IResult Delete(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult(Messages.cretidCarDeleted);
        }

        [SecuredOperation("user")]
        public IDataResult<List<CreditCard>> GetAllByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(c => c.CustomerId == customerId));
        }

        [SecuredOperation("user")]
        public IDataResult<CreditCard> GetById(int id)
        {
            return new SuccessDataResult<CreditCard>(_creditCardDal.Get(c => c.Id == id));
        }
    }
}
