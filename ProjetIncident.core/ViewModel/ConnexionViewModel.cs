using System;
using ProjetIncident.core.Commands;
using ProjetIncident.Core.ViewModel;

namespace ProjetIncident.Core.ViewModel
{
    public class ConnexionViewModel : BaseViewModel
    {

        public string selectedItemDate{
            get; set;
        }

        public DelegateCommand goToIncidentlist {
            get => new DelegateCommand(() =>
            {
                Xamarin.Forms.Application.Current.MainPage = new Views.Incidents();
            });
        }

		public DelegateCommand goToSignUp
		{
			get => new DelegateCommand(() =>
			{
				Xamarin.Forms.Application.Current.MainPage = new Views.SignUp();
			});
		}

        public ConnexionViewModel(){}
    }
}
