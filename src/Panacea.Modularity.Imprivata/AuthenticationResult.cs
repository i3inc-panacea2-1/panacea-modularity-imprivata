namespace Panacea.Modularity.Imprivata
{
    public class AuthenticationResult
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        public string Name { get; set; }
        public string AuthenticationTicket { get; set; }
    }
}