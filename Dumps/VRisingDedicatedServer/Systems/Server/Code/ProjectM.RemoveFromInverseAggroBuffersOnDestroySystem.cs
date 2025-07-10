using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RemoveFromInverseAggroBuffersOnDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1991726846_0;
    
    // unmanaged system, skipped generating example queries

}
