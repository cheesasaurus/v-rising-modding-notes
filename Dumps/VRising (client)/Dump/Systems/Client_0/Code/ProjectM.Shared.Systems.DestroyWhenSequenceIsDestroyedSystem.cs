using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.DestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroyWhenSequenceIsDestroyedSystem : SystemBase
{
    EntityQuery __query_140003924_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_140003924_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DestroyWhenSequenceIsDestroyed>(),
            },
        });
        
    }
    

}
