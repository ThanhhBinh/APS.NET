//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebASP.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int id { get; set; }
        public Nullable<int> category_id { get; set; }
        public Nullable<int> brand_id { get; set; }
        public string name { get; set; }
        public string short_decription { get; set; }
        public string full_description { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<double> price_discount { get; set; }
        public Nullable<int> type_id { get; set; }
        public string slug { get; set; }
        public Nullable<bool> deleted { get; set; }
        public Nullable<bool> show_on_homePage { get; set; }
        public Nullable<int> display_order { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string updated_by { get; set; }
        public string image { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
