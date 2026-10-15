using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagementSystem.Models
{
    public class Learner
    {
        public string LearnerId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public Learner(string LearnerId, string Name, string ContactNumber, string Email)
        {
            this.LearnerId = LearnerId;
            this.Name = Name;
            this.ContactNumber = ContactNumber;
            this.Email=Email;
        }
    }
}
