using System.Linq;
using Project2.DataSource;

namespace Project2
{
    public class MemberManager
    {
        public Member FindMember(int memberId)
        {
            return MemberDataSource.Members.FirstOrDefault(x => x.Id == memberId);
        }
    }
}