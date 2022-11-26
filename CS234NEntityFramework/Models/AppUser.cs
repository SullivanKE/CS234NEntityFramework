using System;
using System.Collections.Generic;

namespace CS234NEntityFramework.Models
{
    public partial class AppUser
    {
        public AppUser()
        {
            InventoryTransactions = new HashSet<InventoryTransaction>();
        }

        public int AppUserId { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
    }
}
