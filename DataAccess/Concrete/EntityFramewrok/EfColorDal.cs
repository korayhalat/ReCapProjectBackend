using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramewrok
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RecapContext>, IColorDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }
    }
}
