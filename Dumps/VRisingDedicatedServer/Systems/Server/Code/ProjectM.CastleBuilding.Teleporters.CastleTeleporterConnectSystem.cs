using Unity.Entities;

namespace ProjectM.CastleBuilding.Teleporters;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleTeleporterConnectSystem : SystemBase
{
    EntityQuery __query_1366495581_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1366495581_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTeleporterComponent>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
