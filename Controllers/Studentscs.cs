using System.Reflection.Metadata.Ecma335;

namespace Students.Controllers
{
    public class Student : IStudent
    {
        Dictionary<int, string> students = new Dictionary<int, string>
         {{ 1, "sakshi" }


         };


        public Student_details GetStudentName(int id)
        {
            Student_details student_Details = new Student_details();

            if (students.ContainsKey(id))
            {
                student_Details = new Student_details
                {
                    studentid = id,
                    studentname = students[id]
                };

            }

            else
            {
                student_Details = new Student_details
                {
                    studentid = 0,
                    studentname = "Not found";
            };

        } 
        
         return student_Details;
            
    }
    



    }

      
