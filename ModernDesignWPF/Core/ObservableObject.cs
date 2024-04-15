using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ModernDesignWPF.Core
{
    //class to notify subscribers (controllers) when a property value changes.

    internal class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //this refers to the current instance of ObjervableOjbect class
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
