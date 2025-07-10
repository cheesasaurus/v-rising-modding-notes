using Unity.Entities;

namespace ProjectM.CastleBuilding.Teleporters;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleTeleporterDisconnectSystem : SystemBase
{
    EntityQuery __query_1366495605_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1366495605_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTeleporterComponent>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
