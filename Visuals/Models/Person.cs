//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Visuals.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.Posts = new HashSet<Post>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiniAvatar { get; set; }
        public string Link { get; set; }
    
        public virtual ICollection<Post> Posts { get; set; }
    }
}
