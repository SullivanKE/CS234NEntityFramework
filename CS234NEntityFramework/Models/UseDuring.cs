using System;
using System.Collections.Generic;

namespace CS234NEntityFramework.Models
{
    public partial class UseDuring
    {
        public UseDuring()
        {
            Adjuncts = new HashSet<Adjunct>();
            RecipeIngredients = new HashSet<RecipeIngredient>();
        }

        public int UseDuringId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Adjunct> Adjuncts { get; set; }
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
