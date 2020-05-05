using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook: BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
