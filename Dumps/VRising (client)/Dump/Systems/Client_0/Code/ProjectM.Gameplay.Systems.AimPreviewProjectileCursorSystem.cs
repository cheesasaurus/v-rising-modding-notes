using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.AimPreviewGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AimPreviewProjectileCursorSystem : SystemBase
{
    EntityQuery __query_1366004535_0;
    EntityQuery __query_1366004535_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1366004535_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreview>(),
                ComponentType.ReadWrite<ProjectM.AimPreviewProjectileCursor>(),
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
            },
        });
        
        __query_1366004535_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewsDisabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
