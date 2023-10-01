using BookingServices.Domain.Common;
using BookingServices.Domain.Exceptions;


namespace BookingServices.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string UserName { get; set; }
        public string DomainName { get; set; }

        public Email()
        {

        }
        public Email(string userName, string domainName)
        {
            UserName = userName;
            DomainName = domainName;
        }

        public static Email For( string email)
        {
            var emailObj = new Email();
            try
            {
                var index = email.IndexOf("@", StringComparison.Ordinal);
                emailObj.UserName = email.Substring(0, index);
                emailObj.DomainName = email.Substring(index + 1);
            }
            catch (Exception ex)
            {

                throw new EmailException(email, ex);
            }
            return emailObj;
        }
        public override string ToString()
        {
            return $"{UserName}@{DomainName}";

        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return UserName;
            yield return DomainName;
        }

    }
}
