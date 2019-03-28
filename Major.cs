using System;
namespace sp19team5project.Models
{
    public class Major
    {
        public Int32 MajorID { get; set; }
        public String Name { get; set; }

        public AppUser AppUser { get; set; }
        public Position Position { get; set; }

    }
}
