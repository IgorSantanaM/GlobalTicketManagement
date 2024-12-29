using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Persistence.Filters
{
    public class FileResultContentTypeOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var fileResultType = context.MethodInfo.ReturnType;

            if (fileResultType == typeof(FileResult))
            {
                if (operation.Responses.ContainsKey("200"))
                {
                    operation.Responses["200"].Content.Add("application/octet-stream", new OpenApiMediaType());
                }
                else
                {
                    operation.Responses.Add("200", new OpenApiResponse
                    {
                        Content =
                    {
                        { "application/octet-stream", new OpenApiMediaType() }
                    }
                    });
                }
            }
        }
    }
}
