namespace Project2
{
    public class Member
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public Member(int id, string fullName)
        {
            this.Id = id;
            this.FullName = fullName;
        }
    }
}