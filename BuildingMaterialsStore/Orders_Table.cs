//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuildingMaterialsStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders_Table
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
    
        public virtual Users_Table Users_Table { get; set; }
    }
}
