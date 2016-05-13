//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMNS.ServiceModel.Service.DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductImportEntity
    {
        public ProductImportEntity()
        {
            this.ProductImportDetailEntities = new HashSet<ProductImportDetailEntity>();
        }
    
        public int ProductImportID { get; set; }
        public Nullable<int> TotalInQuantity { get; set; }
        public Nullable<int> TotalOutQuantity { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<int> ImportStatus { get; set; }
        public string ImportBy { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual ICollection<ProductImportDetailEntity> ProductImportDetailEntities { get; set; }
    }
}