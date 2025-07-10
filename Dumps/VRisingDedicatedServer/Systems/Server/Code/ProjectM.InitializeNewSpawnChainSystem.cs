using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InitializeNewSpawnChainSystem : SystemBase
{
    EntityQuery __query_2071233293_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2071233293_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.SpawnChainData.ActiveChildElement>(),
                ComponentType.ReadOnly<ProjectM.SpawnChainData.SpawnChainConstants>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
