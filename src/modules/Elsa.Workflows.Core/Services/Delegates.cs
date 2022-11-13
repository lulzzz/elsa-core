using Elsa.Workflows.Core.Models;

namespace Elsa.Workflows.Core.Services;

public delegate ValueTask ExecuteActivityDelegate(ActivityExecutionContext context);
public delegate ValueTask ActivityCompletionCallback(ActivityExecutionContext context, ActivityExecutionContext childContext);