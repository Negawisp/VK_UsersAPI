using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.CreateUserState
{
    public class CreateUserStateCommand : IRequest<int>
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
