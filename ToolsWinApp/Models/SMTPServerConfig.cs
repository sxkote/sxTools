using LV.Common.Services;
using LV.Common.Values;
using System.Net;

namespace ToolsWinApp.Models
{
    public class SMTPServerConfig : ServerConfig
    {
        public const string DEFAULT_SERVER_ALIAS = "default";
        public const int DEFAULT_PORT = 25; //587
        public const int DEFAULT_PORT_SSL = 465;

        public string From { get; set; }

        public override int DefaultPort
        { get { return this.SSL ? DEFAULT_PORT_SSL : DEFAULT_PORT; } }

        public SecurityProtocolType SecurityProtocol { get; set; } = 0;

        public SMTPServerConfig() { }

        public SMTPServerConfig(string connectionString)
            : base(connectionString) { }

        public bool IsDefault()
        {
            return this.Server.Equals(DEFAULT_SERVER_ALIAS, CommonService.StringComparison);
        }

        protected override void ParseConnectionStringParams(ParamValueCollection parametres)
        {
            base.ParseConnectionStringParams(parametres);

            if (parametres != null)
            {
                this.From = parametres.GetValue("From") ?? "";
            }
        }

        public override string ToString()
        {
            return $"'From': '{this.From}', 'Server': '{this.Server}', 'Port': '{this.Port}', 'SSL': '{this.SSL}', 'Login': '{this.Login}', 'Password': '{this.Password}'";
        }

        static public SMTPServerConfig Default
        { get { return new SMTPServerConfig() { Server = DEFAULT_SERVER_ALIAS }; } }
    }
}
