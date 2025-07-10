using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ModifyBloodDrainSystem_Spawn : SystemBase
{
    EntityQuery __query_2080842879_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2080842879_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadWrite<ProjectM.ModifyBloodDrainBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
