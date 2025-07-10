using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToEntityHitConsumedGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct ReactToEntityHitConsumedSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_363183552_0;
    
    // unmanaged system, skipped generating example queries

}
