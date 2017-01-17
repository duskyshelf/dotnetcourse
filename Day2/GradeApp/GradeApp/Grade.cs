using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeApp
{
    enum MyGradeAnswers
    {
        A,
        B,
        C,
        D,
        E,
        F
    }
    class Grade
    {
        public string IfStatementExample(string grade =  "")
        {
            string result = "Invalid grade given";

            grade = grade.ToUpper();

            if (grade == MyGradeAnswers.A.ToString())
            {
                result = "Excellent";
            }
            else if (grade == "B")
            {
                result = "Good";
            }
            else if (grade == "C")
            {
                result = "Fair";
            }
            else if (grade == "D")
            {
                result = "Poor";
            }
            else if (grade == "E")
            {
                result = "Bad";
            }
            else if (grade == "F")
            {
                result = "Fail";
            }

            return result;
        }

        public string SwitchStatementExample(string grade)
        {
            string result = "Invalid grade given";

            switch (grade.ToUpper())
            {
                case "A":
                    result = "Super";
                    break;
                case "B":
                    result = "You're great";
                    break;
                case "C":
                    result = "Wooow";
                    break;
                case "D":
                    result = "Amazing";
                    break;
                case "E":
                    result = "Passable I guess";
                    break;
                case "F":
                    result = "Participation award";
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
