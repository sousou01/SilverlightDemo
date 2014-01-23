using SilverlightNavigDemo.Service.Client.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace SilverlightNavigDemo.Service.Client.ServiceContracts
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        PersonDto GetUserDetails(PersonDto person);
    }
}
