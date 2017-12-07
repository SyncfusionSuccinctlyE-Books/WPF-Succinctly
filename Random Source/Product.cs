using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace WPFMVVMValidation
{
    public class Product : INotifyPropertyChanged , IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _totalAmount = 5;
        private string _name = "Shoe box";

        [Required(ErrorMessage = "TotalAmount property is required")]
        public int TotalAmount
        {
            get { return _totalAmount; }
            set
            {
                _totalAmount = value;
                OnPropertyChanged("TotalAmount");
            }
        }

        [Required(ErrorMessage = "The Name property is required")]
        [StringLength(4, ErrorMessage = "The Name value cannot exceed 4 characters. ")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (PropertyChanged != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

        //Not used by WPF
        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get 
            {

                if (columnName == "TotalAmount")
                {
                    bool valid = true;
                    if (_totalAmount > 10)
                    {
                        valid = false;
                    }

                    if (!valid)
                    {
                        return "The total amount cannot exceed 10!";
                    }
                    return null;
                }

                

                return _validateAttributes(columnName);

            }
        }

        private string _validateAttributes(string columnName)
        {
            bool valid;

            PropertyInfo propertyInfo = typeof(Product).GetProperty(columnName);

            if (propertyInfo == null)
                throw new NullReferenceException();

            //iterate through the attributes
            object[] attributes = propertyInfo.GetCustomAttributes(false);

            if (attributes.Length == 0)
                return null;

            foreach (object attr in attributes)
            {
                if (attr is RequiredAttribute)
                {
                    if (this.Name == null || this.Name == String.Empty)
                    {
                        return string.Format("The value of {0} cannot be empty!", columnName);
                    }

                    return null;
                }
            }

            return null;
        }
    }
}
