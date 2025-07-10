using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class GetTranslationOnUpdateSystem : SystemBase
{
    EntityQuery __query_2080359729_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2080359729_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GetTranslationOnUpdate>(),
            },
        });
        
    }
    

}
