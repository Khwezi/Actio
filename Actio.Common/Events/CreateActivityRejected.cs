namespace Actio.Common.Events
{
    public class CreateActivityRejected : IRejectedEvent
    {
        public string Reason { get; }

        public string Code { get; }

        public string Email { get; set; }

        protected CreateActivityRejected()
        {

        }

        public CreateActivityRejected(string reason, string code, string email)
        {
            Reason = reason;
            Code = code;
            Email = email;
        }
    }
}