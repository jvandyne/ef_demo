//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.askcts.demos.ef.sample.dto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee: IFirstName
    {
        public Employee()
        {
            this.Addresses = new HashSet<Address>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
