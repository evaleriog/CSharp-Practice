namespace Gradebook{
    public class Student{
        private string firstName;
        private string lastName;
        private int grade;

        public string FirstName{
            set
            {
                if(!string.IsNullOrEmpty(value)){
                    firstName = value;
                }
                else
                {
                    firstName = "Empty";
                }
            }
            get{
                return firstName;
            }
        }

        public string LastName{
            set{
                if(!string.IsNullOrEmpty(value)){
                    lastName = value;
                }else{
                    lastName = "Empty";
                }
            }
            get{
                return lastName;
            }
        }

        public int Grade{
            set{
                if(value > 0 && value < 13){
                    grade = value;
                }
                else{
                    grade = 1;
                }
            }
            get{
                return grade;
            }
        }
        public Student(string fname, string lname, int grade)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.grade = grade;
        }
    }
}