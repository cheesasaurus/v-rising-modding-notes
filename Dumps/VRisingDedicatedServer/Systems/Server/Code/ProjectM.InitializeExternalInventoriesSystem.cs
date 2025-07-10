using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[UpdateBefore(typeof(ProjectM.ReactToPlayerCharacterSpawnSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class InitializeExternalInventoriesSystem : SystemBase
{
    EntityQuery __query_22130882_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_22130882_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InventoryOwner>(),
                ComponentType.ReadWrite<ProjectM.InventoryInstanceElement>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
