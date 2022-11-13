using Elsa.Workflows.Core.Models;
using Elsa.Workflows.Core.State;
using Elsa.Workflows.Management.Models;

namespace Elsa.Workflows.Api.Endpoints.WorkflowInstances.Get;

public class Request
{
    public string Id { get; set; } = default!;
}

public class Response
{
    public string DefinitionId { get; init; } = default!;
    public string DefinitionVersionId { get; init; } = default!;
    public int Version { get; init; }
    public WorkflowState WorkflowState { get; set; } = default!;
    public WorkflowStatus Status { get; set; }
    public WorkflowSubStatus SubStatus { get; set; }
    public string? CorrelationId { get; set; }
    public string? Name { get; set; }
    public WorkflowFault? Fault { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? LastExecutedAt { get; set; }
    public DateTimeOffset? FinishedAt { get; set; }
    public DateTimeOffset? CancelledAt { get; set; }
    public DateTimeOffset? FaultedAt { get; set; }
}