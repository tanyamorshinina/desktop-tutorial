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
    
    public partial class Doljnosti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doljnosti()
        {
            this.Sotrudnikis = new HashSet<Sotrudniki>();
        }
    
        public int id_dioljnosti { get; set; }
        public string doljnost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sotrudniki> Sotrudnikis { get; set; }
    }
}
