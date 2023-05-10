using Application.DbContexts;
using Application.Service.AddUser;
using Domain.Model;
using Service.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.CreateUser
{
    internal class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUsersDbContext _usersDbContext;

        public CreateUserCommandHandler(IUsersDbContext usersDbContext)
        {
            _usersDbContext = usersDbContext;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            UserGroup userGroup = _usersDbContext.UserGroups.Single(ug => ug.Code == request.UserGroupCode);
            if (userGroup == null)
            {
                throw new Exception($"User group with code '{request.UserGroupCode}' not found.");
            }

            if (request.UserGroupCode == "Admin" &&
                _usersDbContext.Users.Any(u => u.UserGroup.Code == "Admin"))
            {
                throw new Exception("There is already a user with code 'Admin', there can only be one.");
            }

            UserState userState = _usersDbContext.UserStates.Single(us => us.Code == "Active");

            User user = new User
            {
                Login = request.Login,
                Password = request.Password,
                CreatedDate = DateTime.Now,
                UserGroup = userGroup,
                UserState = userState
            };

            await _usersDbContext.Users.AddAsync(user, cancellationToken);
            await _usersDbContext.SaveChangesAsync(cancellationToken);

            return user.Id;
        }
    }
}
