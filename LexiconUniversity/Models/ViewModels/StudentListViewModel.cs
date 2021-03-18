using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconUniversity.Models.ViewModels
{
    public class StudentListViewModel
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string FullName { get; set; }
        public string AdressStreet { get; set; }
    }
}
