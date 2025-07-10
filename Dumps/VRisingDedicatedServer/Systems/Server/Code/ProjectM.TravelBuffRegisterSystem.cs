using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[UpdateAfter(typeof(ProjectM.SetupInitialStatesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TravelBuffRegisterSystem : SystemBase
{
    EntityQuery __query_615927256_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_615927256_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TravelBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
