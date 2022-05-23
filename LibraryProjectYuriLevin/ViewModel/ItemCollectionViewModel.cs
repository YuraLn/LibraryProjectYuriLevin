using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Model.LibraryItems;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using View.Windows;

namespace LibraryProjectYuriLevin.ViewModel
{
    public class ItemCollectionViewModel : ViewModelBase
    {
        public RelayCommand AddWindowCommand { get; set; }
        public RelayCommand SearchWindowCommand { get; set; }
        public RelayCommand EditWindowCommand { get; set; }
        public ItemCollection Items { get; set; }
        

        public ItemCollectionViewModel()
        {
            AddWindowCommand = new RelayCommand(AddWindowBook);

            //SearchWindowCommand = new RelayCommand(SearchWindow);
            //EditWindowCommand = new RelayCommand(EditWindow);
            //Items = Instance;
            //OCShowList = Items.Items;
        }

        private void AddWindowBook()
        {
            var open = new AddBookWindow();
            open.Show();
        }
    }
}
