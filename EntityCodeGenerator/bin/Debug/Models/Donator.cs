using System;
using System.Collections.Generic;

namespace Daheng88.Model.Models
{
    public partial class Donator
    {
        public Donator()
        {
            this.PayWays = new List<PayWay>();
        }

        public int DonatorId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime DonateDate { get; set; }
        public virtual ICollection<PayWay> PayWays { get; set; }
    }
}
