using D6TWO_Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Dal
{
    public class OrderDal
    {

        DBHelper db = new DBHelper();
        public List<OrderTable> ShowOrder()
        {

            string sql = string.Format("select * from OrderTable");
            return DBHelper.GetList<OrderTable>(sql);

        }

    }
}
