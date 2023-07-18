namespace Mail
{
    public class SmtpMail
    {
        private string v;

        public SmtpMail(string v)
        {
            this.v = v;
        }

        public string From { get; set; }
        public string To { get; set; }

        public string Subject { get; set; }
        public string HtmlBody { get; set; }


    }
    public class SmtpServer
    {
        private string v;

        public SmtpServer(string v)
        {
            this.v = v;
        }

        public string User { get; set; }
        public string Password { get; set; }
        public string ConnectType { get; set; }
    }
}