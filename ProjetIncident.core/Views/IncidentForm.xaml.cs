using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetIncident.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IncidentForm : ContentPage
    {
        public IncidentForm()
        {
            this.BindingContext = new ViewModel.IncidentFormViewModel();
            InitializeComponent();
        }
    }
}
