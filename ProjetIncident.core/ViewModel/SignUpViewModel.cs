using System;
using ProjetIncident.core.Commands;
using ProjetIncident.Core.ViewModel;

namespace ProjetIncident.Core.ViewModel
{
    public class SignUpViewModel : BaseViewModel
    {
        public SignUpViewModel()
        {
        }

		public DelegateCommand goToIncidents
		{
			get => new DelegateCommand(() =>
			{
				Xamarin.Forms.Application.Current.MainPage = new Views.Incidents();
			});
		}

    }
}
