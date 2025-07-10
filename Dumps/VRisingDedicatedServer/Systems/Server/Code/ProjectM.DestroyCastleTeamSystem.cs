using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DestroyCastleTeamSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _DestroyCastleTeamQuery;
    EntityQuery __query_57017623_0;
    
    // unmanaged system, skipped generating example queries

}
