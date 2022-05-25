//using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.LibraryItems
{
    public class AbstructItem
    {
        public string DateAdded { get; set; }
        public string Title { get; set; }
      

        public AbstructItem(string title)
        {
            //Add date on implamintation
            DateAdded = DateTime.UtcNow.ToString("dd-MM-yyyy");
            Title = title;
        }   
    }
}
