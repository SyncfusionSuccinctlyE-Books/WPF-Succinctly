using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ContactMvvm
{
    public class ContactManagerViewModel : ObservableCollection<Contact>
    {
        #region "constructor"

        public ContactManagerViewModel()
        {
            PrepareContactCollection();
        }

        #endregion

        #region "private routines"

        private void PrepareContactCollection()
        {
            //create new contacts and add them to the ViewModel's
            //ObservableCollection

            var ContactOne = new Contact
            {
                FirstName = "John",
                LastName = "Doe",
                EmailAddress = "jdoe@email.com",
                TelephoneNumber = "555-555-5555"

            };

            Add(ContactOne);

            var ContactTwo = new Contact
            {
                FirstName = "Bob",
                LastName = "Watson",
                EmailAddress = "bwatson@email.com",
                TelephoneNumber = "555-555-5555"

            };

            Add(ContactTwo);

            var ContactThree = new Contact
            {
                FirstName = "Joe",
                LastName = "Johnson",
                EmailAddress = "jjohnson@email.com",
                TelephoneNumber = "555-555-5555"

            };

            Add(ContactThree);

        }

        #endregion
    }
}
