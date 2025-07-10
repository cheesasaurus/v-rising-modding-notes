using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ChangeAllegianceEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_57017658_0;
    EntityQuery __query_57017658_1;
    
    // unmanaged system, skipped generating example queries

}
