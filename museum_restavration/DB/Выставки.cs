//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace museum_restavration.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Выставки
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Выставки()
        {
            this.Экспонат_выставка = new HashSet<Экспонат_выставка>();
        }
    
        public int Код_выставки { get; set; }
        public System.DateTime Дата_начала { get; set; }
        public System.DateTime Дата_окончания { get; set; }
        public string Название { get; set; }
        public string Место_проведения { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Экспонат_выставка> Экспонат_выставка { get; set; }
    }
}
