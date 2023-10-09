using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MMGAgenda.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<DailyViewModel> days;

        public MainViewModel()
        {
            Days = new ObservableCollection<DailyViewModel>();
        }

        [RelayCommand]
        public void AddDay()
        {
            var day = new DailyViewModel();
            day.Date = DateOnly.FromDateTime(DateTime.Now).AddDays(dayOffset).ToString();
            Days.Add(day);
            dayOffset++;
        }


        private int dayOffset = 0;
    }
}
