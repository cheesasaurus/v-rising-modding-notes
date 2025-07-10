using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MountStatsSpawnSystem_Server : SystemBase
{
    EntityQuery __query_1228665725_0;
    EntityQuery __query_1228665725_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1228665725_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Mountable>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SaddleBearer>(),
            },
        });
        
        __query_1228665725_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Mountable>(),
                ComponentType.ReadWrite<ProjectM.Network.NetworkInterpolated_Shared>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
