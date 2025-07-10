using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DestroyCastleHeartSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1288932670_0;
    EntityQuery __query_1288932670_1;
    EntityQuery __query_1288932670_2;
    
    // unmanaged system, skipped generating example queries

}
