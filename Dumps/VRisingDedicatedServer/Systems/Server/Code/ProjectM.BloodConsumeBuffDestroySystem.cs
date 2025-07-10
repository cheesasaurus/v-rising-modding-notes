using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BloodConsumeBuffDestroySystem : SystemBase
{
    EntityQuery __query_503711662_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_503711662_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.BloodConsumeDebuff>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
