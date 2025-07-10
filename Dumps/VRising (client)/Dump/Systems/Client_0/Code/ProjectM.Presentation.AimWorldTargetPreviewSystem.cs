using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(ProjectM.AimPreviewGroup))]
public class AimWorldTargetPreviewSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery _ShowQuery;
    EntityQuery __query_1143347464_0;
    EntityQuery __query_1143347464_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ShowQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.ShowWorldTargetPreviewTag>(),
            },
        });
        
        __query_1143347464_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildMode>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1143347464_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewsDisabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
