

namespace WorkerProject.Entities
{
    class Department
    {
        public string Name { get; set; } 
        
        public Department(string name)
        {
            this.Name = name;
        }
        public Department() { }

        override
            public string ToString()
        {
            return "  Department: " + Name;
        }
    }

}
