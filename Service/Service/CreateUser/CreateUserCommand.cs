using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.AddUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string UserGroupCode { get; set; }
    }
}
