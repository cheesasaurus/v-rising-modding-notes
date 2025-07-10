using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroyWhenDisabledSystem : SystemBase
{
    EntityQuery __query_1216346856_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1216346856_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DestroyWhenDisabled>(),
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
