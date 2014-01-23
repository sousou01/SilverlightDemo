using SilverlightNavigDemo.Service.Client.Dto;
using SilverlightNavigDemo.UserService;
using SilverlightNavigDemo.Views.Login;
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightNavigDemo.ViewModels.Login
{
    public class LoginViewModel:ViewModel
    {
        UserServiceClient _client;
        public LoginViewModel()
        {
            _client = new UserServiceClient();
            AfterCheckCompeted();
        }

        bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                RaisePropertyChanged("IsBusy");
            }
        }

        string _userName;
        public string Username { get { return _userName; }
            set
            {
                _userName = value;
                RaisePropertyChanged("Username");
            }
        }

        string _password;
        public string Password { get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged("");
            }
        }

        CheckCommand _checkCommand;
        public CheckCommand CheckCommand { get { return _checkCommand ?? (_checkCommand = new CheckCommand(this)); } }

        public bool CanCheck(object obj)
        {
            return true;
        }

        public void Check(object obj)
        {
            IsBusy = true;
            try 
            {
                _client.GetUserDetailsAsync(new PersonDto { Username = Username, Password = Password });
            }
            catch { }
            finally 
            {
            }
        }

        private void AfterCheckCompeted()
        {
            PersonDto result;
                
                _client.GetUserDetailsCompleted += (s, e) =>
                {
                    result = e.Result;

                    var win = new UserExistsWindow();
                    if (!string.IsNullOrWhiteSpace(result.Name))
                    {
                        win.UserText.Text = result.ToString();
                    }
                    else
                    {
                        win.UserText.Text = "nie istnieje taki uzytkownik.";
                    }
                    win.Show();
                    IsBusy = false;
                };
        }
    }

    public class CheckCommand : ICommand
    {
        LoginViewModel _model;
        public CheckCommand(LoginViewModel model)
        {
            _model = model;
        }

        public bool CanExecute(object parameter)
        {
            return _model.CanCheck(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _model.Check(parameter);
        }
    }
}
