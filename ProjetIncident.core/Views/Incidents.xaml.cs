using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjetIncident.Core.Views
{
    public partial class Incidents : ContentPage
    {

        public Incidents()
        {
			this.BindingContext = new ViewModel.IncidentsViewModel();
			//((ViewModel.ProjetIncidentViewModel) BindingContext).MonTexte = "Bonjour à tous";
			InitializeComponent();
        }

		/*void Handle_Clicked(object sender, System.EventArgs e)
        {
            ((ViewModel.ProjetIncidentViewModel)BindingContext).MonTexte = "lol";
        }

        void Handle_Clicked_Liste(object sender, System.EventArgs e)
        {
            ((ViewModel.ProjetIncidentViewModel)BindingContext).MaListe.Add("je être nouvel élément");
        }

        void SupprListeEl(object sender, System.EventArgs e)
        {
            ((ViewModel.ProjetIncidentViewModel)BindingContext).MaListe.Remove(((ViewModel.ProjetIncidentViewModel)BindingContext).MaSelection);
        }*/
         
	}
}
