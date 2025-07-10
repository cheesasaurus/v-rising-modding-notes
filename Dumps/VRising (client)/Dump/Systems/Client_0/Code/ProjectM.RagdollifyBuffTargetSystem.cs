using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RagdollifyBuffTargetSystem : SystemBase
{
    EntityQuery __query_596649958_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_596649958_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.RagdollifyBuffTarget>(),
            },
        });
        
    }
    

}
