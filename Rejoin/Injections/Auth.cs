using Microsoft.AspNetCore.Http;
using Rejoin.Data;
using Rejoin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rejoin.Injections
{
    public interface IAuth
    {
        User User { get; }
    }

    public class Auth : IAuth
    {
        private readonly RejoinDbContext _context;
        private readonly IHttpContextAccessor _accessor;

        public Auth(RejoinDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public User User
        {
            get
            {
                string token = string.Empty;

                bool hasHeader = this._accessor.HttpContext.Request.Cookies.TryGetValue("token", out token);

                if (!hasHeader)
                {
                    return null;
                }

                User LoggedUser = _context.Users.FirstOrDefault(c => c.Token == token);

                if (LoggedUser == null)
                {
                    return null;
                }

                return LoggedUser;
            }
        }

    }
}
