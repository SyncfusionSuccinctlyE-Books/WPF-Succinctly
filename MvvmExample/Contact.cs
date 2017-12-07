using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ContactMvvm
{
    public class Contact : INotifyPropertyChanged
    {
        #region "private fields"

        private string _firstName;
        private string _fullName;
        private string _lastName;
        private string _telephoneNumber;
        private string _emailAddress;

        #endregion

        #region "Public Properties"

        public string FirstName
        {
            get { return _firstName; }
            set 
            { 
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string FullName
        {
            get 
            {
                _fullName = string.Format("{0} {1}", _firstName, _lastName);
                
                return _fullName;
            }

            set
            {
                _fullName = value;
                OnPropertyChanged("FullName");
            }
        }


        public string EmailAddress
        {
            get { return _emailAddress; }
            set 
            { 
                _emailAddress = value;
                OnPropertyChanged("EmailAddress");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set 
            { 
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string TelephoneNumber
        {
            get { return _telephoneNumber; }
            set 
            { 
                _telephoneNumber = value;
                OnPropertyChanged("LastName");
            }
        }

        #endregion


        #region "INotifyPropertyChanged members"

        public event PropertyChangedEventHandler PropertyChanged;

        //This routine is called each time a property value has been set.  This will        cause an event to notify WPF via databinding that a change has occurred.
        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
        
    }
}
