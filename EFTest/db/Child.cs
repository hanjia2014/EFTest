namespace EFTest.db
{
    using System;
    using System.Collections.Generic;

    public partial class Child
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }

        public virtual Parent Parent { get; set; }
    }
}