using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleAttackEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _CastleAnnouncementQuery;
    EntityQuery __query_1288933138_0;
    EntityQuery __query_1288933138_1;
    EntityQuery __query_1288933138_2;
    
    // unmanaged system, skipped generating example queries

}
