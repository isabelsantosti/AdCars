﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdCars.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterView : ContentPage
    {
        public RegisterView()
        {
            InitializeComponent();
            BtnCadastrar.IsEnabled = false;
            BtnCadastrar.TextColor = Color.Gray;
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (EntCheck.IsChecked)
            {
                BtnCadastrar.IsEnabled = true;
                BtnCadastrar.TextColor = Color.White;
            }
            else
            {
                BtnCadastrar.IsEnabled = false;
                BtnCadastrar.TextColor = Color.Gray;
            }
        }

        private void Button_Unfocused(object sender, FocusEventArgs e)
        {
            
        }
    }
}