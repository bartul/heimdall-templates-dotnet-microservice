using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;

namespace Heimdall.Templates.DotNet.Microservice.Application
{
    public sealed class ApplicationFacadeOptions
    {
        [Required]
        public IConfigurationSection? ConnectionStrings { get; set; }

        public bool EnableAutoMigrations { get; set; } = false;
    }
}