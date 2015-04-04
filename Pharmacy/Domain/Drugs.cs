using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    class Drugs : DomainBasic
    {
        private string name;
        private string sku;        
        private string format;
        private int amount;
        private string typeOfAmount;
        private string madein;
        private float prices;
        private float discount;
        private string gender;
        private string ingredients;
        private string cautions;
        private string recommended;
        private string description;
        private string feature;
        private int inventory;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string SKU
        {
            get
            {
                return sku;
            }
            set
            {
                sku = value;
            }
        }        
        public string Format
        {
            get
            {
                return format;
            }
            set
            {
                format = value;
            }
        }
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        public string TypeOfAmount
        {
            get
            {
                return typeOfAmount;
            }
            set
            {
                typeOfAmount = value;
            }
        }
        public string MadeIn
        {
            get
            {
                return madein;
            }
            set
            {
                madein = value;
            }
        }

        public float Prices
        {
            get
            {
                return prices;
            }
            set
            {
                prices = value;
            }
        }
        public float Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
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
        public string Ingredients
        {
            get
            {
                return ingredients;
            }
            set
            {
                ingredients = value;
            }
        }
        public string Cautions
        {
            get
            {
                return cautions;
            }
            set
            {
                cautions = value;
            }
        }
        public string Recommended
        {
            get
            {
                return recommended;
            }
            set
            {
                recommended = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string Feature
        {
            get
            {
                return feature;
            }
            set
            {
                feature = value;
            }
        }

        public int Inventory
        {
            get
            {
                return inventory;
            }
            set
            {
                inventory = value;
            }
        }
    }
}
