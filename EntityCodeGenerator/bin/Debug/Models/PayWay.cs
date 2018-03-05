using System;
using System.Collections.Generic;

namespace Daheng88.Model.Models
{
    public partial class PayWay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Donator_DonatorId { get; set; }
        public virtual Donator Donator { get; set; }
    }
}
