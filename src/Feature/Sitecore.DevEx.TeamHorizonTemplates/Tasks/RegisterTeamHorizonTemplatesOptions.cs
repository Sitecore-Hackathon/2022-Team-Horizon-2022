using Sitecore.DevEx.Client.Tasks;
using System.Collections.Generic;

namespace Sitecore.DevEx.TeamHorizonTemplates.Tasks
{
    public class RegisterTeamHorizonTemplatesOptions : TaskOptionsBase
    {
        public string CommandId { get; set; }

        public string Config { get; set; }

        public string EnvironmentName { get; set; }

        public List<string> Targets { get; set; }

        public override void Validate()
        {
            this.Require("CommandId");
            this.Require("Config");
            this.Default("EnvironmentName", (object)"default");
        }
    }
}