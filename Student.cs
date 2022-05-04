using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EventsITStepAcademy
{
    class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //----------------------------------------------------------

        private string surname;

        public string Surname
        {
            get { return surname; }
            set 
            { 
                surname = value;
                OnProperyChanged("Surname");
            }
        }
        //---------------------------------------

        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                OnProperyChanged("Name");
            }
        }
        //---------------------------------------

        private string patronymic;

        public string Patronymic
        {
            get { return patronymic; }
            set 
            { 
                patronymic = value;
                OnProperyChanged("Patronymic");
            }
        }
        //---------------------------------------

        private void OnProperyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, null);
            }
        }
        //--------------------------------------------------------
    }
}
