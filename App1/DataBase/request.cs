//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class request
    {
        public int id { get; set; }
        public System.DateTime date_request { get; set; }
        public string description { get; set; }
        public int id_hardware { get; set; }
        public int id_fault { get; set; }
        public int id_klient { get; set; }
    
        public virtual fault fault { get; set; }
        public virtual Hardware Hardware { get; set; }
        public virtual Klient Klient { get; set; }
    }
}
