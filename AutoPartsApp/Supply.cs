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
    
    public partial class Supply
    {
        public int IdSupply { get; set; }
        public int IdAutoPart { get; set; }
        public int IdProvider { get; set; }
        public System.DateTime DateSupply { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    
        public virtual AutoParts AutoParts { get; set; }
        public virtual Providers Providers { get; set; }
    }
}
