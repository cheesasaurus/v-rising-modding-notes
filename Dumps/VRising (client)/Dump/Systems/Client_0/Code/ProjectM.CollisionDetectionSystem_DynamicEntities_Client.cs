using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.CollisionGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CollisionDetectionSystem_DynamicEntities_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _DynamicQuery;
    EntityQuery __query_998138892_0;
    
    // unmanaged system, skipped generating example queries

}
