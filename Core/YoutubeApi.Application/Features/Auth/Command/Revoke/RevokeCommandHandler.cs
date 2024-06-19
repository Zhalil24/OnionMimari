﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Application.Bases;
using YoutubeApi.Application.Features.Auth.Rules;
using YoutubeApi.Application.Interfaces.AutoMapper;
using YoutubeApi.Application.Interfaces.UnitOfWorks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Application.Features.Auth.Command.Revoke
{
    internal class RevokeCommandHandler : BaseHandler, IRequestHandler<RevokeCommandRequest, Unit>
    {
        private readonly UserManager<User> userManager;
        private readonly AuthRules authRules;


        public RevokeCommandHandler(IMapper mapper,UserManager<User> userManager,AuthRules authRules,IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.userManager = userManager;
            this.authRules = authRules;
        }

        public async Task<Unit> Handle(RevokeCommandRequest request, CancellationToken cancellationToken)
        {
            User user = await userManager.FindByEmailAsync(request.Email);
            await authRules.EmailAdressShouldBeValid(user);

            user.RefreshToken = null;
            await userManager.UpdateAsync(user);


            return Unit.Value;
        }
    }
}
