using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UnitSpawnerOnDestroySystem : SystemBase
{
    EntityQuery __query_2099432280_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2099432280_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UnitSpawnerstation>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
