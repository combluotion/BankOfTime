//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankOfTime.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class complain
    {
        public int Id { get; set; }
        public string Issuer { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual user user1 { get; set; }
        public virtual user user2 { get; set; }
    }
}
