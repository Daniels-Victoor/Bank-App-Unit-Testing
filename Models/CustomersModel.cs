using System;

namespace Models
{
    public class CustomersModel
    {
        public string CostumerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public CustomersModel(string costumerId, string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            CostumerId = costumerId;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;

        }
    }
}
