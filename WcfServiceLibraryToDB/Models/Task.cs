using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryToDB.Models
{
    [DataContract]
    public class Task
    {
        public Task(int taskId, string nameTask, int workload, DateTime startDate, DateTime expiryDate, string status, string staff)
        {
            TaskId = taskId;
            NameTask = nameTask;
            Workload = workload;
            StartDate = startDate;
            ExpiryDate = expiryDate;
            Status = status;
            Staff = staff;
        }

        [DataMember]
        public int TaskId { get; set; }
        [DataMember]
        public string NameTask { get; set; }
        [DataMember]
        public int Workload { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime ExpiryDate { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Staff { get; set; }
    }
}
