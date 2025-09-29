namespace SAP_Mobile.Models.Request
{
    public class LoginRequest
    {
        public LoginRequest(string companyDB, string userName, string password)
        {
            CompanyDB = companyDB;
            UserName = userName;
            Password = password;
        }

        public string CompanyDB { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
