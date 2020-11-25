using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Assignment_1.Models
{
    public class Employee : INotifyPropertyChanged
    {
        #region Private Members

        private int _id;
        private string _name;
        private string _email;
        private string _contact;

        #endregion

        #region Public Members
        public int Id
        {
            get { return _id; }
            set 
            { 
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                OnPropertyChanged("Name");
            }
        }


        public string Email
        {
            get { return _email; }
            set 
            { 
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        public string Contact
        {
            get { return _contact; }
            set 
            { 
                _contact = value;
                OnPropertyChanged("Contact");
            }
        }

        #endregion

        #region INotifyPropertyChanged Member

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string PropertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        #endregion
    }
}
