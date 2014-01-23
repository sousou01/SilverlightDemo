using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SilverlightNavigDemo.Service.Client.Dto
{
    [DataContract]
    public class PersonDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string StreetAddress { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string ZipCode { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Email { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Format("Imie: {0}", Name));
            builder.AppendLine(string.Format("Nazwisko: {0}", Surname));
            builder.AppendLine(string.Format("Ulica: {0}", StreetAddress));
            builder.AppendLine(string.Format("Miasto: {0} {1}", ZipCode, City));
            builder.AppendLine(string.Format("Email: {0}", Email));
            return builder.ToString();
        }
    }
}
