using System;
using System.Collections.Generic;
using System.Text;
using AownApp.Models;

namespace AownApp.business
{
    public interface IProductService
    {

        List<ProductModel> GetAllData();

    }
}
