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
    
    public partial class TechnicalEquipment
    {
        public int id_description_TE { get; set; }
        public int in_amount_TE { get; set; }
        public string name_TE { get; set; }
        public string value_TE { get; set; }
    
        public virtual DescriptionRoom DescriptionRoom { get; set; }
    }
}
