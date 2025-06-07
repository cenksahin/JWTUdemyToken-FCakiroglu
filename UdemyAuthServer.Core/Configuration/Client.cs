namespace UdemyAuthServer.Core.Configuration
{
    public class Client
    {
        public string Id { get; set; }
        public string Secret { get; set; }

        //istek atılacak api adreslerini tutacak
        public List<string> Audiences { get; set; }
    }
}