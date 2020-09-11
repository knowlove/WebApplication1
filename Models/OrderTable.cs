using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace D6TWO_Model
{
    public class OrderTable
    {

        [Key]
        public int OrderId				 { get; set; }
        public string ShaoppingName		 { get; set; }
        public string MoneyType			 { get; set; }
        public int MoneyState			 { get; set; }
        public string UserName			 { get; set; }
        public string OrderPhone			 { get; set; }
        public string OrderAddress		 { get; set; }
        public string OrderState			 { get; set; }
        public string DistributionDealer	 { get; set; }
        public string Engine				 { get; set; }
        public string CarColor			 { get; set; }
        public string OrderTime			 { get; set; }
        public string MoneyTime			 { get; set; }
        public string MoneyBank			 { get; set; }
        public string PayType				 { get; set; }
        public string PayMoney			 { get; set; }
        public string LatelyTime			 { get; set; }
        public string OrderTransfer { get; set; }

    }
}
