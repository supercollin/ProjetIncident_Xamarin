using System;
using System.Collections.ObjectModel;

namespace ProjetIncident.Core.ViewModel
{
    public class IncidentsViewModel : BaseViewModel
    {
        public IncidentsViewModel()
        {
			IncidentsList = new ObservableCollection<string>();
        }

        public ObservableCollection<string> IncidentsList{
            get => GetProperty<ObservableCollection<string>>();
            set{SetProperty(value);}
        }
    }
}
