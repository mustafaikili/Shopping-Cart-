﻿using ShoppingCart.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Business.Abstract
{
    public interface IProductService
    {
        Product Get(int productId);
        ICollection<Product> GetList(int categoryID);
    }
}
