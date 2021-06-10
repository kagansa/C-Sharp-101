using System.Collections.Generic;

namespace Project2.DataSource
{
    public static class MemberDataSource
    {
        public static List<Member> Members;

        static MemberDataSource()
        {
            Members = InitializeMembers();
        }

        private static List<Member> InitializeMembers()
        {
            return new List<Member>()
            {
                new Member(1,"Kağan Saygın"),
                new Member(2,"Ayşe Taş"),
                new Member(3,"Fatma Demir"),
                new Member(4,"Hayriye Yılmaz")
            };
        }
    }
}