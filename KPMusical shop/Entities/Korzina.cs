//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KPMusical_shop.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Korzina
    {
        public int id_prodaji { get; set; }
        public System.DateTime date { get; set; }
        public int id_tovara { get; set; }
        public Nullable<int> kolichestvo { get; set; }
    
        public virtual Pridaji Pridaji { get; set; }
        public virtual Tovari Tovari { get; set; }
    }
}
