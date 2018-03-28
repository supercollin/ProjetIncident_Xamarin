using System;
using System.Collections.ObjectModel;
using ProjetIncident.core.Commands;
using ProjetIncident.Core.Model;

namespace ProjetIncident.Core.ViewModel
{
    public class IncidentsViewModel : BaseViewModel
    {
        public IncidentsViewModel()
        {
			IncidentsList = new ObservableCollection<string>();
            var incident1 = new Incident("c cassé", 4.02, 45.652, 650, new DateTime());
            IncidentsList.Add(incident1.StatusChangedDate.ToString());
        }

        public ObservableCollection<string> IncidentsList{
            get => GetProperty<ObservableCollection<string>>();
            set{SetProperty(value);}
        }

		public DelegateCommand goToDetails
		{
			get => new DelegateCommand(() =>
			{
				Xamarin.Forms.Application.Current.MainPage = new Views.IncidentsDetails();
			});
		}

		public DelegateCommand AddIncident
		{
			get => new DelegateCommand(() =>
			{
				Xamarin.Forms.Application.Current.MainPage = new Views.IncidentForm();
			});
		}
    }
}
