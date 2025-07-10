using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.BeforeTransformSystemGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct InputCommandStateCopySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _UpdateQuery;
    EntityQuery __query_844126051_0;
    
    // unmanaged system, skipped generating example queries

}
