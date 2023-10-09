using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MMGAgenda.ViewModels
{
    public partial class DailyViewModel : ObservableObject
    {
        [ObservableProperty]
        private string date;

        [ObservableProperty]
        private ObservableCollection<String> appointments;

        public DailyViewModel() 
        {
            Appointments = new ObservableCollection<String>();
            Appointments.Add("Bernardi F");
            Appointments.Add("Giussani E");
            Appointments.Add("Giussani T");
        }
    }
}
