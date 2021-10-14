using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCodes.Entities
{
    public class Player : IEntitiy
    {
        public string NationalityId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerLastName { get; set; }
        public int BirthYear { get; set; }
    }
}
