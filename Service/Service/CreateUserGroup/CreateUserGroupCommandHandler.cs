using Domain.Model;
using Service.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.CreateUserGroup
{
    internal class CreateUserGroupCommandHandler : IRequestHandler<CreateUserGroupCommand, int>
    {
        private readonly IUsersDbContext _usersDbContext;

        public CreateUserGroupCommandHandler(IUsersDbContext usersDbContext)
        {
            _usersDbContext = usersDbContext;
        }

        public async Task<int> Handle(CreateUserGroupCommand request, CancellationToken cancellationToken)
        {
            UserGroup userGroup = new UserGroup
            {
                Code = request.Code,
                Description = request.Description
            };

            await _usersDbContext.UserGroups.AddAsync(userGroup, cancellationToken);
            await _usersDbContext.SaveChangesAsync(cancellationToken);

            return userGroup.Id;
        }
    }
}
