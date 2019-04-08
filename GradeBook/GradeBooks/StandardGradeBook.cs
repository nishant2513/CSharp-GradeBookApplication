

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook: BaseGradeBook
    {
        public StandardGradeBook(string name,bool is_weighted):base(name,is_weighted)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
