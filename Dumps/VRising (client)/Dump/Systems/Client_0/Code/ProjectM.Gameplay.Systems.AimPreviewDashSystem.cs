using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.AimPreviewGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AimPreviewDashSystem : SystemBase
{
    EntityQuery __query_1613480878_0;
    EntityQuery __query_1613480878_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1613480878_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreview>(),
                ComponentType.ReadWrite<ProjectM.AimPreviewDash>(),
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
            },
        });
        
        __query_1613480878_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewsDisabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
