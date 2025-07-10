using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnPrefabOnDestroySystem : SystemBase
{
    EntityQuery __query_1817791980_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1817791980_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnPrefabOnDestroy>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
