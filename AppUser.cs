using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sp19team5project.Models
{
    public class AppUser
    {
        public Int32 UserID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        public String Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime GraduationDate { get; set; }

        public String PositionType { get; set; }
        public String GPA { get; set; }
        public String AssociatedCompany { get; set; }


        //navigation property to Role
        public Role Role { get; set; }

        // navigation properties to interview
        List<Interview> InterviewsGiven;
        List<Interview> InterviewsSuffered;


    }


}
