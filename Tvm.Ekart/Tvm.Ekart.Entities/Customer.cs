namespace Tvm.Ekart.Entities
{
    using System.Collections.Generic;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public string CustomerId { get; set; }

        public string ContactName { get; set; }

        public string Address { get; set; }
        
		public string City { get; set; }

        public string PostalCode { get; set; }

        public string Phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
