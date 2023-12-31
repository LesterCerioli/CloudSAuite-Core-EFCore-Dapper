﻿using CloudSuite.Domain.ValueObjects;
using CloudSuite.Modules.Application.Handlers.User.Responses;
using MediatR;

namespace CloudSuite.Modules.Application.Handlers.User.Request
{
    public class CheckUserExistsByCpfRequest : IRequest<CheckUserExistsByCpfResponse>
    {
        public Guid Id { get; set; }

        public Cpf Cpf { get; private set; }

        public CheckUserExistsByCpfRequest(Cpf cpf)
        {
            Id = Guid.NewGuid();
            Cpf = cpf;
        }

        public CheckUserExistsByCpfRequest() { }
    }
}
