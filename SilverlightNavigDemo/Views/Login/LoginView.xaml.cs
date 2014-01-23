using SilverlightNavigDemo.ViewModels.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightNavigDemo.Views.Login
{
    public partial class LoginView : ChildWindow
    {
        public LoginView()
        {
            DataContext = new LoginViewModel();
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            BusyIndicator.IsBusy = true;
            //Thread.Sleep(5000);
            //BusyIndicator.IsBusy = false;
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

