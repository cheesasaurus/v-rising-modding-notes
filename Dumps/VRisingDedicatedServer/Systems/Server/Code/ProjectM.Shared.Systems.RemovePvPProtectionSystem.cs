using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RemovePvPProtectionSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _RemovePvPProtectionEventQuery;
    EntityQuery __query_724309037_0;
    EntityQuery __query_724309037_1;
    EntityQuery __query_724309037_2;
    
    // unmanaged system, skipped generating example queries

}
