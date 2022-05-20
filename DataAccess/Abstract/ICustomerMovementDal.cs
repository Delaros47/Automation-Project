﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Universal.DataAccess;

namespace DataAccess.Abstract
{
    public interface ICustomerMovementDal:IEntityRepository<CustomerMovement>
    {

    }
}
