//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoPartsApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales
    {
        public int IdSale { get; set; }
        public int IdAutoPart { get; set; }
        public int IdSeller { get; set; }
        public int IdClient { get; set; }
        public System.DateTime DateSale { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
    
        public virtual AutoParts AutoParts { get; set; }
        public virtual Clients Clients { get; set; }
        public virtual Sellers Sellers { get; set; }
    }
}