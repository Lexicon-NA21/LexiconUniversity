using LexiconUniversity.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconUniversity.Models.ViewModels
{
    public class StudentAddViewModel
    {
        [StringLength(20)]
        public string FirstName { get; set; }

        [CheckName]
        public string LastName { get; set; }

        public string Email { get; set; }

        [CheckStreetNr(max: 10)]
        public string AdressStreet { get; set; }
        public string AdressCity { get; set; }
        public string AdressZipCode { get; set; }
    }
}
