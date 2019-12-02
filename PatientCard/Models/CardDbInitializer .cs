using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PatientCard.Models
{
    public class CardDbInitializer : DropCreateDatabaseAlways<PatientCardContext>
    {
        protected override void Seed(PatientCardContext db)
        {
            db.Cards.Add(new Card { Name="Jimmi", Surname="Jimmi", Iin="850128389394", Phone="87024859459", Address="Astana c, A-98 st, 9 h, 9 fl",
                                    Complain= "head ache", Diagnosis= "migraine", DoctorName="Andrea", DoctorSurname="Va", Specilest= "therapist", Date=DateTime.Now
            });

            base.Seed(db);
        }
    }
}