using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconUniversity.Models.Entities
{
    public class Adress
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public int StudentId { get; set; }

        //Navigation prop
        public Student Student { get; set; }
    }
}
