using MVC_test.Models;

namespace MVC_test.DataBase
{
    public static class db
    {
        //public static List<Student> students = new List<Student>();
        public static List<Student> students = new List<Student>()
        {
            new Student(){Name="shayan",Family="Madahi",National_code="0521511410",Phone="01234567899"},
            new Student(){Name="ali",Family="Hasany",National_code="0521611410",Phone="01234567899"},
            new Student(){Name="reza",Family="Zahedy",National_code="0521511510",Phone="01234567899"}
        };
    }
}
