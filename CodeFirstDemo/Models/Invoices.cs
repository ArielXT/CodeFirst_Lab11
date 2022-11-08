//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFirstDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoices()
        {
            this.Customers = new HashSet<Customers>();
        }
    
        public int InvoiceID { get; set; }
        public System.DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<int> InvoiceDetail_InvoiceDetailID { get; set; }
        public Nullable<int> Product_ProductID { get; set; }
        public Nullable<int> Seller_SellerID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual InvoiceDetails InvoiceDetails { get; set; }
        public virtual Products Products { get; set; }
        public virtual Sellers Sellers { get; set; }
    }
}
