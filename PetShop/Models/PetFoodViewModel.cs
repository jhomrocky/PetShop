using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop.Models
{
    public class PetFoodViewModel //viewmodel (this) is like a "container" of information being sent that is connected
    {
        public Pet pet { get; set; }
        public ICollection<Food> food { get; set; }

    }
}