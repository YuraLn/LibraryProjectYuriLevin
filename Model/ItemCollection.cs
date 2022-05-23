using Model.LibraryItems;
using System.Collections.ObjectModel;

namespace Model
{
    internal class ItemCollection
    {
        public ItemCollection Items { get; set; }
        public ObservableCollection<AbstructItem> ListToShow{ get; set; }


        
    }
}
