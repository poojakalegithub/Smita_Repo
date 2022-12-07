using DapperCRUD_ClassLibrary_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperCRUD.Domain.Models
{
    public class Subjects
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int StudId { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
