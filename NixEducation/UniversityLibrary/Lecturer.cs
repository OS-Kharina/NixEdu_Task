using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityLibrary
{
    public enum LecturerType
    {
        Professor,
        AssistantProfessor,
        Dean,
        DeputyDean,
        SeniorLecturer
    }
    public class Lecturer: Person, IAdmin
    {
        public LecturerType Title { get; set; }
    }
}
