namespace BussinessObjects
{
    public class AccountMember
    {
        public string MemberId { get; set; } = null;
        public string MemberPassword { get; set; } = null;
        public string Fullname { get; set; } = null;
        public string? EmailAddress { get; set; }
        public int? MemberRole { get; set; }
    }
}
