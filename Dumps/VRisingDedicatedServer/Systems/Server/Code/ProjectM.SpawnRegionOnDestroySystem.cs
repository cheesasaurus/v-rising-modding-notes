using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnRegionOnDestroySystem : SystemBase
{
    EntityQuery __query_1104049251_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1104049251_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.SpawnRegionSpawnSlotEntry>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
