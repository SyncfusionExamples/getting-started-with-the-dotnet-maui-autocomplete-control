using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiExample
{
    public class DataViewModel
    {
        public ObservableCollection<DataModel> SocialMedia {  get; set; }
        public DataViewModel() {
            SocialMedia = new ObservableCollection<DataModel> { 
                new DataModel() { Name = "Facebook", ID = 0 },
                new DataModel() { Name = "Telegram", ID = 1 },
                new DataModel() { Name = "YouTube", ID = 2 },
                new DataModel() { Name = "Instagram", ID = 3 },
                new DataModel() { Name = "Twitter", ID = 4 },
                new DataModel() { Name = "Google Plus", ID = 5 },
                new DataModel() { Name = "WhatsApp", ID = 6 },
                new DataModel() { Name = "Televzr", ID = 7 },
                new DataModel() { Name = "Tik Tok", ID = 8 }
            };
        }
    }
}
