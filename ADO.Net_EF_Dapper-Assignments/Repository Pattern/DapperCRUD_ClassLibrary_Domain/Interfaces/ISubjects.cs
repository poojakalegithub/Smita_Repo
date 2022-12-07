using DapperCRUD.Domain.Models;
using DapperCRUD_ClassLibrary_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperCRUD.Domain.Interfaces
{
    public interface ISubjects
    {
        public IEnumerable<Subjects> GetSubjects();

        public int AddSubjects(Subjects subjects);

        public int UpdateSubjects(Subjects subjects, int SubjectId);

        public int DeleteSubjects(int StudId);
    }
}
