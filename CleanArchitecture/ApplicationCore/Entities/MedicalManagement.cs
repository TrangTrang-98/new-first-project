using System;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class MedicalManagement : IAggregateRoot
    {
        public string MedicineID{get; set;}
        public string MedicineName{get; set;}
        
    }
}