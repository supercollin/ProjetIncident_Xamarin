using System;
using System.Collections.ObjectModel;
using ProjetIncident.core.Commands;
using ProjetIncident.Core.ViewModel;

namespace ProjetIncident.Core.ViewModel
{
    public class IncidentsDetailsViewModel : BaseViewModel
    {
        public IncidentsDetailsViewModel()
		{
			IncidentsListPhotos = new ObservableCollection<string>();
			IncidentsListPhotos.Add("Il n'y a aucune photo pour cet Incident");
		}

		public ObservableCollection<string> IncidentsListPhotos
		{
			get => GetProperty<ObservableCollection<string>>();
			set { SetProperty(value); }
		}

		public DelegateCommand Back
		{
			get => new DelegateCommand(() =>
			{
				Xamarin.Forms.Application.Current.MainPage = new Views.Incidents();
			});
		}
    }
}
