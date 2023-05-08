﻿using PersonaEditor.Common;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media.Imaging;

namespace PersonaEditor.ViewModels.Editors
{
    public abstract class TextureAtlasBase<T> : BindingObject
        where T : TextureObjectBase
    {
        private T _selectedObject;

        public ObservableCollection<T> Objects { get; } = new ObservableCollection<T>();

        public T SelectedObject
        {
            get => _selectedObject;
            set
            {
                var oldVal = _selectedObject;
                if (SetProperty(ref _selectedObject, value))
                {
                    if (oldVal != null)
                        oldVal.IsSelected = false;
                    if (_selectedObject != null)
                        _selectedObject.IsSelected = true;
                }
            }
        }

        public abstract BitmapSource TextureImage { get; }

        public Rect Rect => TextureImage == null
            ? new Rect()
            : new Rect(0, 0, TextureImage.PixelWidth, TextureImage.PixelHeight);

        public abstract string Name { get; }
    }
}