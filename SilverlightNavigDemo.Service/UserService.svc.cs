using SilverlightDemo.Data;
using SilverlightNavigDemo.Service.Client.Dto;
using SilverlightNavigDemo.Service.Client.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SilverlightNavigDemo.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {

        public PersonDto GetUserDetails(Client.Dto.PersonDto person)
        {
            //return new PersonDto();
            var ctx = new DbEntities();
            var personFromDb = ctx.People.FirstOrDefault(p => p.Username == person.Username);
            if (personFromDb == null) return new PersonDto();
            //
            return new PersonDto
            {
                City = personFromDb.City,
                Password = personFromDb.Password,
                Username = personFromDb.Username,
                Email = personFromDb.Email,
                Id = personFromDb.Id,
                Name = personFromDb.Name,
                StreetAddress = personFromDb.StreetAddress,
                Surname = personFromDb.Surname,
                ZipCode = personFromDb.ZipCode
            };
        }
    }
}
