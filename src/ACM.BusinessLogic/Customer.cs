namespace ACM.BusinessLogic
{
    public class Customer
    {
        private string _lastName;

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                var fullfName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullfName))
                    {
                        fullfName += ", ";
                    }
                    fullfName += FirstName;
                }

                return fullfName;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public static int InstanceCount { get; set; }
    }
}
