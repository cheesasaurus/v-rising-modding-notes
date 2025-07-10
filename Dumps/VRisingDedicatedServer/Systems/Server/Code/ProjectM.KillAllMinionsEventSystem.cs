using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiSubGroup2))]
[RequireMatchingQueriesForUpdateAttribute]
public class KillAllMinionsEventSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_166460288_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.KillAllMinionsEvent>(),
            },
        });
        
        __query_166460288_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.KillAllMinionsEvent>(),
            },
        });
        
    }
    

}
