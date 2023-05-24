using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMauiApp
{
    public partial class ItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private Color _color;
        [ObservableProperty]
        private int _width;
        [ObservableProperty]
        private int _index;
    }
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ItemViewModel> _items;

        public MainPageViewModel()
        {
            _items = new ObservableCollection<ItemViewModel>();
            for (int i = 0; i < 20; i++)
            {
                _items.Add(new ItemViewModel { Index = i, Color = GetColor(i), Width = GetWidth(i) }) ;
            }
        }

        private int GetWidth(int i)
        {
            switch(i%4)
            {
                case 0: return 50;
                case 1: return 70;
                case 2: return 80;
                case 3: return 85;
                default: return 10;
            }
        }

        private Color GetColor(int i)
        {
            switch (i % 4)
            {
                case 0: return Color.FromRgb(255, 0, 0);
                case 1: return Color.FromRgb(0, 255, 0);
                case 2: return Color.FromRgb(0, 0, 255);
                case 3: return Color.FromRgb(255, 255, 0);
                default: return Color.FromRgb(0, 0, 0);
            }
        }
    }
}
