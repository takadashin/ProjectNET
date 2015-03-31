using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    class Customers : DomainBasic
    {
        private string name;
        private string gender;
        private string address;
        private int yearOfBirth;
        private string insurance;
        private string allergy;
        private Accounts createdBy;
        private Accounts modifiedBy;

        public string Name
        {
            get {             
                return name; 
            }
            set { 
                name = value; 
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public string Address
        {
            get{ 
                return address;
            }
            set{    
                address=value;
            }
        }
        public int YearOfBirth
        {
            get{ 
                return yearOfBirth;
            }
            set{
                yearOfBirth=value;
            }
        }
        public string Insurance
        {
            get{ 
                return insurance;
            }
            set{
                insurance=value;
            }
        }
        public string Allergy
        {
            get { 
                return allergy;
            }
            set {
                allergy = value;
            }
        }
        public Accounts CreatedBy
        {
            get
            {
                return createdBy;
            }
            set
            {
                createdBy = value;
            }
        }
        public Accounts ModifiedBy
        {
            get
            {
                return modifiedBy;
            }
            set
            {
                modifiedBy = value;
            }
        }
    }
}
