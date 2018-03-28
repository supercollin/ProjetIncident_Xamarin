using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjetIncident.Core.Views
{
    public partial class IncidentsDetails : ContentPage
    {
        public IncidentsDetails()
        {
            this.BindingContext = new ViewModel.IncidentsDetailsViewModel();
            InitializeComponent();
        }
    }
}
