using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroySequenceWhenSelfIsDestroyedSystem : SystemBase
{
    EntityQuery __query_140003954_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_140003954_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DestroySequenceWhenSelfIsDestroyed>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
