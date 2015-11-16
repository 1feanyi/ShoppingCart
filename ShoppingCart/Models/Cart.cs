using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Models
{
    public class Cart
    {
        public int Id { get; set; }

        // EF attributes to make field unique and set max length.
        //
        // This field will be searched for on each page load to 
        // find the user's cart. This is a good performance improvement.
        //
        // By default, if no string length is identified, EF will create 
        // string fields as nvarchar(max) making index to be 
        // incompatible with this type of field
        [Index(IsUnique=true)]
        [StringLength(255)]
        public string SessionId { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}