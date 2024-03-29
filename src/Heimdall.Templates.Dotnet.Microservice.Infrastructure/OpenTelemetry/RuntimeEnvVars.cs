using Microsoft.Identity.Client;
using System.Net.Http.Headers;

namespace Heimdall.Templates.Dotnet.Microservice.Infrastructure.OpenTelemetry
{
    //TODO: Review & refactor merged code
    public static class RuntimeEnvVars
    {
        public const string ArcK8sCertEnvVarName = "ARC_K8S_CLIENT_CERT_SECRET";
        public const string ArcK8sClientIdEnvVarName = "ARC_K8S_CLIENT_ID";
        public const string ArcDataOpenTelemetryClientIdEnvVarName = "ARCDATA_OTEL_CLIENT_ID";
        public const string AuthorizationEnvironmentEnvVarName = "AUTHORIZATION_ENV";
        public const string ClientIdEnvVarName = "CLIENT_ID";
        public const string ClientSecretEnvVarName = "CLIENT_SECRET";
        public const string DemoFlavor = "DEMO_FLAVOR";
        public const string OtelFqdnEnvVarName = "OTEL_EXPORTER_OTLP_LOGS_ENDPOINT";
        public const string TenantIdEnvVarName = "TENANT_ID";
        public const string UamiClientIdEnvVarName = "UAMI_CLIENT_ID";
    }
}