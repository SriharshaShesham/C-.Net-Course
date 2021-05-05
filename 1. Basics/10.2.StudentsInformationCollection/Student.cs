namespace _10._2.StudentsInformationCollection
{
    class Student
    {
        private static string _studentID;
        private static string _firstName;

        private static string _lastName;
        private static string _gender;

        private static int _marks;

        public string StudentID
        {

            get
            {
                return _studentID;

            }

            set
            {

                _studentID = value;

            }

        }

        public string FirstName
        {

            get
            {
                return _firstName;

            }

            set
            {

                _firstName = value;

            }

        }

        public string LastName
        {

            get
            {
                return _lastName;
            }

            set
            {

                _lastName = value;

            }

        }

        public string Gender
        {
            get
            {
                return _gender;

            }

            set
            {
                _gender = value;

            }

        }

        public int Marks
        {
            get
            {
                return _marks;
            }
            set
            {

                _marks = value;

            }
        }
    }
}