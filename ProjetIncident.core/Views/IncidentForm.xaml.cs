using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjetIncident.Core.Views
{
    public partial class IncidentForm : ContentPage
    {
        public IncidentForm()
        {
            this.BindingContext = new ViewModel.IncidentFormViewModel();
            InitializeComponent();
        }
    }
}
