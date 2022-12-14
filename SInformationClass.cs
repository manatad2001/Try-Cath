using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch
{
    public int SetStudentNo, SetContactNo = 0;
    public string SetPrograms, SetGender, SetBirthday, SetFullname = "";
 
    class SInformationClass
    {
    }
    private void frmRegistration_Load(object sender, EventArgs e)
        {
        string[] ListOfProgram = new string[] {
            "BS Information Technology",
            "BS Computer Science",
            "BS Information Systems",
            "BS in Accountancy",
            "BS in Hospitality Management",
            "BS in Tourism Management"
        };
         for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        /////return methods 
        public long StudentNumber(string studNum) {

	        _StudentNo = long.Parse(studNum);

	        return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
	        if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
	        {
	           _ContactNo =long.Parse(Contact);
	        }
	
	        return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial) {
	        if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
	        {
		        _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
	        }
	
	        return _FullName;
        }

        public int Age(string age)
        {
	        if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
	        {
		        _Age = Int32.Parse(age);
	        }
	
	        return _Age;
        }
            /////return methods 
            public long StudentNumber(string studNum)
            {

                _StudentNo = long.Parse(studNum);

                return _StudentNo;
            }

            public long ContactNo(string Contact)
            {
                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);
                }

                return _ContactNo;
            }

            public string FullName(string LastName, string FirstName, string MiddleInitial)
            {
                if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
                {
                    _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
                }

                return _FullName;
            }

            public int Age(string age)
            {
                if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    _Age = Int32.Parse(age);
                }

                return _Age;
            }
}
