using System;
using System.Collections.Generic;
using System.Text;
using AownApp.dataaccess;
using AownApp.Models;

namespace AownApp.business
{
    public class ProductService : IProductService
    {

        public List<ProductModel> GetAllData()
        {

            return CRUD.GetAllData();

        }

    }
}
