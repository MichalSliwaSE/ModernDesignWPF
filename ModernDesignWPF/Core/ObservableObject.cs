using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesignWPF.Core
{
    //class to notify subscribers (controllers) when a property value changes.

    internal class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //this refers to the current instance of ObjervableOjbect class
        protected void OnPropertyChanged ([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke (this, new PropertyChangedEventArgs (name));
        }
    }
}
