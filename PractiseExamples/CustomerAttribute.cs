using System;
using System.Collections.Generic;
using System.Text;

namespace PractiseExamples
{
    public class CustomerAttribute :Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }




        public CustomerAttribute(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public CustomerAttribute()
        {
            this.Id = -1;
            this.Name = String.Empty;
        }
    }
}
