using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjetIncident.Core.Views
{
    public partial class Connexion : ContentPage
    {
        public Connexion()
        {
            this.BindingContext = new ViewModel.ConnexionViewModel();
            InitializeComponent();
        }
    }
}
