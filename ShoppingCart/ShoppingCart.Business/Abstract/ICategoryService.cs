﻿using ShoppingCart.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
