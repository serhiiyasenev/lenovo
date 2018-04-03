using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    abstract class Employee
    {
        private string firstName;
        private string lastName;
        private string address;
        private string empNumber = "";

        #region GetSet
        public string EmpNumber
        {
            get { return empNumber; }
            set
            {
                empNumber = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        #endregion

        public virtual void Login()
        {

        }

        public virtual void LogOff()
        {

        }

        public abstract void EatLunch();

    }
}