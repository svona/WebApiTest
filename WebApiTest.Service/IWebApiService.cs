using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest.Service
{
    public interface IWebApiService
    {
        IMediator Mediator { get; set; }
    }
}
