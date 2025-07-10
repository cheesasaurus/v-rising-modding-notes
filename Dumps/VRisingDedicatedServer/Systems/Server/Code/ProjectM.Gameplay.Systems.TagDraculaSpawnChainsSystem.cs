using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TagDraculaSpawnChainsSystem : SystemBase
{
    EntityQuery __query_62796368_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_62796368_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnChainData.SpawnChainInstance>(),
                ComponentType.ReadOnly<ProjectM.StaticTransformIndex>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
