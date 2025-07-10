using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnAimPreviewSystem : SystemBase
{
    EntityQuery __query_386076860_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_386076860_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreview>(),
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.BuffInstantiatedAimPreview>(),
            },
        });
        
    }
    

}
