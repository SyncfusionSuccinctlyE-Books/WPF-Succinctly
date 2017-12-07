using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBinding
{
    public class Person : INotifyPropertyChanged
    {
        #region "private members"
        
        private string _FirstName;
        private string _LastName;
        
        #endregion

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
                    OnPropertyChanged("LastName");
                    
                }
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
