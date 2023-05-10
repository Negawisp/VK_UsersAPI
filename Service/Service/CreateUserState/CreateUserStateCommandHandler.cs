using Domain.Model;
using Service.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.CreateUserState
{
    internal class CreateUserStateCommandHandler : IRequestHandler<CreateUserStateCommand, int>
    {
        private readonly IUsersDbContext _usersDbContext;

        public CreateUserStateCommandHandler(IUsersDbContext usersDbContext)
        {
            _usersDbContext = usersDbContext;
        }

        public async Task<int> Handle(CreateUserStateCommand request, CancellationToken cancellationToken)
        {
            UserState userState = new UserState
            {
                Code = request.Code,
                Description = request.Description
            };

            await _usersDbContext.UserStates.AddAsync(userState, cancellationToken);
            await _usersDbContext.SaveChangesAsync(cancellationToken);

            return userState.Id;
        }
    }
}
