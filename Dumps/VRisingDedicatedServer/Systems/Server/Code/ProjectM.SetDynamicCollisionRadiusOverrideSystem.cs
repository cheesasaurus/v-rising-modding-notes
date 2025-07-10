using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetDynamicCollisionRadiusOverrideSystem : SystemBase
{
    EntityQuery __query_895504308_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_895504308_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.DynamicCollision>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
