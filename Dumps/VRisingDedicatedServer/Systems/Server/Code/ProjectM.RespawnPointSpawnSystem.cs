using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[UpdateAfter(typeof(ProjectM.Network.SetupNetworkIdSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class RespawnPointSpawnSystem : SystemBase
{
    EntityQuery __query_1150277200_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1150277200_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RespawnPoint>(),
                ComponentType.ReadOnly<ProjectM.UserOwner>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
