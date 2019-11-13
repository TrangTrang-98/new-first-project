using System;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class Doctor : IAggregateRoot
    {
        public int DoctorId{get; set;}

        public string DoctorName{get; set;}

        public DateTime Birthday{get; set;}

        public string DoctorPhone{get; set;}

        public string DeptId{get; set;}

        

    }
}