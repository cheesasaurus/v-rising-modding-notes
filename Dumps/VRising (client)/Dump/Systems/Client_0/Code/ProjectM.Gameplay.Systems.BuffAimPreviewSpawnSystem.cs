using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BuffAimPreviewSpawnSystem : SystemBase
{
    EntityQuery __query_1044570606_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1044570606_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.BuffAimPreview>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
