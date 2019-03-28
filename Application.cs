using System;
namespace sp19team5project.Models
{
    public enum Status { Accepted, Rejected, Pending }
    public class Application
    {
        public Int32 ApplicationID { get; set; }
        public Status Status { get; set; }
        public String AppliedPosition { get; set; }
        public String Company { get; set; }

        public AppUser AppUser { get; set; }
        public Position Position { get; set; }

    }
}
