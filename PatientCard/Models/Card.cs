using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientCard.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Iin { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Specilest { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string Diagnosis { get; set; }
        public string Complain { get; set; }
        public DateTime Date { get; set; }

    }
}