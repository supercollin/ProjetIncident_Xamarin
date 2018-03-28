using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProjetIncident.Core.Views
{
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            this.BindingContext = new ViewModel.SignUpViewModel();
            InitializeComponent();
        }
    }
}
