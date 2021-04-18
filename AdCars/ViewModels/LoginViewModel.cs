﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AdCars.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region PROPRIEDADES DE BINDING DA LOGINVIEW
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; OnPropertyChanged(); }
        }
        private string _Senha;
        public string Senha
        {
            get { return _Senha; }
            set { _Senha = value; OnPropertyChanged(); }
        }
        private bool _isBusy;
        public bool isBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; OnPropertyChanged(); }
        }
        #endregion
        public Command LoginCommand { get; set; }
        public Command RegistroCommand { get; set; }

        public LoginViewModel()
        {
            RegistroCommand = new Command(async () => await RegisterCommandAsync());
            LoginCommand = new Command(async () => await LoginCommandAsync());
        }

        private Task RegisterCommandAsync()
        {
            //await Application.Current.MainPage.Navigation.PushAsync(ne)
        }


        //MÉTODO PARA REALIZAR A LÓGICA DE LOGIN... AINDA NÃO IMPLEMENTADO
        private async Task LoginCommandAsync()
        {
            if (isBusy)
                return;
        }
    }
}
