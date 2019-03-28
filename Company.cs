using System;
using System.ComponentModel.DataAnnotations;

namespace sp19team5project.Models
{
    public class Company
    {
        public Int32 CompanyID { get; set; }
        public String Email { get; set; }
        public String Description { get; set; }
        public String Industry { get; set; }
        public String PositionTitle { get; set; }

        [DataType(DataType.Date)]
        public DateTime InterviewDate { get; set; }


        public AppUser AppUser { get; set; }
        public Position Position { get; set; }
    }
}
