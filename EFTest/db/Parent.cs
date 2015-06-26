namespace EFTest.db
{
    using System;
    using System.Collections.Generic;

    public partial class Parent
    {
        public Parent()
        {
            this.Children = new HashSet<Child>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Child> Children { get; set; }
    }
}