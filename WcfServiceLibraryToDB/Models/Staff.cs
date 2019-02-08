using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryToDB.Models
{
    [DataContract]
    public class Staff
    {
        public Staff(int staffId, string surname, string name, string patronymic)
        {
            StaffId = staffId;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
        }

        [DataMember]
        public int StaffId { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Patronymic { get; set; }
    }
}
