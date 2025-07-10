using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.VisibilitySystem_Client))]
[RequireMatchingQueriesForUpdateAttribute]
public class VisibilitySystem_CopyStateFromBuffTarget : SystemBase
{
    EntityQuery __query_14898768_0;
    EntityQuery __query_14898768_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_14898768_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hideable>(),
                ComponentType.ReadOnly<ProjectM.Attached>(),
                ComponentType.ReadOnly<ProjectM.Hideable_CopyFromAttachParent>(),
            },
        });
        
        __query_14898768_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.AttachToCharacterTransformBuff>(),
            },
        });
        
    }
    

}
