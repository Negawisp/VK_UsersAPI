using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.CreateUserGroup
{
    public class CreateUserGroupCommand : IRequest<int>
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
