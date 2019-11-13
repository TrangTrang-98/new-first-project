using System;
using System.Collections.Generic;
namespace ApplicationCore.Entities
{
    public class Patient{
        public int PatientId{get; set;}

        public string PatientName{get; set;}

        public Boolean Gender{get; set;}
       
        public DateTime Birthday{get; set;}

        public string Address{get; set;}

        public string Phone{get; set; }


    }

}