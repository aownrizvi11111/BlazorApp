using System;
using System.Collections.Generic;
using System.Text;

namespace AownApp.dataaccess
{
    public class DalProduct:IProductDal
    {
        public void GetData()
        {
            DBHelper.GetConnection();
        }
    }
}
