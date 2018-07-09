namespace ConsoleAppGit
{
    public class Customer
    {
        public int PropInt { get; set; }
        public string Texto { get; set; }

        private string _firstName;
        public string FistName
        {
            get { return _firstName; }
            set
            {
                _firstName = value.ToUpper();
            }
        }
    }
}
