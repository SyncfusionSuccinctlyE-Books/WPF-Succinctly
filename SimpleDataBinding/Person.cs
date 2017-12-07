using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDataBinding
{
    public class Person : INotifyPropertyChanged
    {

        private string _FirstName;
        private string _LastName;
        private string _FullName;

        #region "Public Properties"

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if (_FirstName != value)
                {
                    _FirstName = value;
                    this.FullName = string.Format("{0} {1}", _FirstName, _LastName); 
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (_LastName != value)
                {
                    _LastName = value;
                    this.FullName = string.Format("{0} {1}", _FirstName, _LastName);
                    OnPropertyChanged("LastName");
                    
                }
            }
        }

        public string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                _FullName = value;
                OnPropertyChanged("FullName");
            }
        }

        #endregion


        #region "INotifyPropertyChanged members"

        public event PropertyChangedEventHandler PropertyChanged;

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
