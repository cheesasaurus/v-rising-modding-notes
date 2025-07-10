using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.TeleportationRequestSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class UsePortalSystem : SystemBase
{
    EntityQuery __query_695019499_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_695019499_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.UsePortal>(),
            },
        });
        
    }
    

}
