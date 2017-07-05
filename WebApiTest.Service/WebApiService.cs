using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using StructureMap;

namespace WebApiTest.Service
{
    public class WebApiService : IWebApiService
    {
        public IMediator Mediator { get; set; }

        public WebApiService()
        {
            var container = new Container();
            container.Configure(cfg =>
            {
                cfg.Scan(scanner => 
                {
                    scanner.AssemblyContainingType(this.GetType());
                    scanner.WithDefaultConventions();
                    scanner.AddAllTypesOf(typeof(IAsyncRequestHandler<,>));
                    scanner.AddAllTypesOf(typeof(IAsyncRequestHandler<>));
                    scanner.AddAllTypesOf(typeof(IRequestHandler<,>));
                    scanner.AddAllTypesOf(typeof(IRequestHandler<>));
                });

                cfg.For<SingleInstanceFactory>().Use<SingleInstanceFactory>(ctx => t => ctx.GetInstance(t));
                cfg.For<MultiInstanceFactory>().Use<MultiInstanceFactory>(ctx => t => ctx.GetAllInstances(t));
                cfg.For<IMediator>().Use<Mediator>();
            });
            
            this.Mediator = container.GetInstance<IMediator>();
        }
    }
}
