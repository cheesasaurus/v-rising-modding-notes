using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.DestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroyDeadSystem : SystemBase
{
    EntityQuery __query_2089721792_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2089721792_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
