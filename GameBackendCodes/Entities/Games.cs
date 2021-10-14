using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCodes.Entities
{
    public class Games : IEntitiy
    {
        public string GameId { get; set; }
        public string GameName { get; set; }
        public string GameCategory { get; set; }

    }
}
