﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonaEditor.Common
{
    public abstract class BindingObject : IEventWrapper
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {

        }

        protected void Notify([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
                return false;

            storage = value;
            Notify(propertyName);
            return true;
        }
    }
}