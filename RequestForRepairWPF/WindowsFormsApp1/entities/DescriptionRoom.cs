//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class DescriptionRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DescriptionRoom()
        {
            this.Software = new HashSet<Software>();
            this.SpecialEquipment = new HashSet<SpecialEquipment>();
            this.TechnicalEquipment = new HashSet<TechnicalEquipment>();
        }
    
        public int id_type_room_DR { get; set; }
        public int id_description_DR { get; set; }
        public string description_DR { get; set; }
        public string comment_DR { get; set; }
    
        public virtual TypeRoom TypeRoom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Software> Software { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialEquipment> SpecialEquipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechnicalEquipment> TechnicalEquipment { get; set; }
    }
}
