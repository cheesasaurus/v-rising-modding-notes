using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct IdleInteractionSystem_BuffDestroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_107901330_0;
    EntityQuery __query_107901330_1;
    
    // unmanaged system, skipped generating example queries

}
