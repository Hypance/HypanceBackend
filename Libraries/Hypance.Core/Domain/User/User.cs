using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypance.Core.Domain.User
{
	public class User
	{
        public string Email { get; set; }
        public string Password { get; set; }
        public int TelegramChanelId { get; set; }
        public string TelegramApi { get; set; }
    }
}
