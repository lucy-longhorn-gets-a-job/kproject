using System;
namespace sp19team5project.Models
{
    public enum PositionType { Internship, FullTime }
    public class Position
    {
        public Int32 PositionID { get; set; }
        public String PositionTitle { get; set; }
        public String PositionDescription { get; set; }
        public PositionType PositionType { get; set; }
        public String CompanyName { get; set; }
        public String Industry { get; set; }
        public String Location { get; set; }


        public AppUser AppUser { get; set; }
        public Company Company { get; set; }
        public Application Application { get; set; }


    }
}
