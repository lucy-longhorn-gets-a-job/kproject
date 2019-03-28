using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace sp19team5project.Models
{
    public enum RoomNumber {Room1, Room2, Room3, Room4}
    public class Interview

    {
        public Int32 InterviewID { get; set; }
        public String Time { get; set; }
        public RoomNumber RoomNumber { get; set; }

        [InverseProperty("Interviewer")]
        public AppUser Interviewer { get; set; }
        [InverseProperty("Interviewee")]
        public AppUser Interviewee { get; set; }

        public Position Position { get; set; }
    }
}
