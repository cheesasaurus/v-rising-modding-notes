using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HybridAttachPointTransformSystem : SystemBase
{
    EntityQuery __query_2106996486_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2106996486_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.AttachToCharacterTransformBuff>(),
            },
        });
        
    }
    

}
