namespace SAP_Mobile.Models.Response
{
    public class LoginResponse
    {
        public string? sessionId { get; set; }
        public string? version { get; set; }
        public int sessionTimeout { get; set; }
    }
}
