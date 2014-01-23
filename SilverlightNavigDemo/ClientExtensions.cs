using SilverlightNavigDemo.Service.Client.Dto;
using SilverlightNavigDemo.UserService;
using System;
using System.Net;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightNavigDemo
{
    public static class ClientExtensions
    {
        public static IObservable<PersonDto> GetUserAwait(this UserServiceClient client, PersonDto person)

        {
            return Observable.FromAsyncPattern(client
            //return Observable.FromEventPattern(client, "");
        }
    }
}
