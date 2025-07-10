using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InsideSystem_Server : SystemBase
{
    EntityQuery __query_904964152_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_904964152_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadWrite<ProjectM.InsideBuff>(),
            },
        });
        
    }
    

}
