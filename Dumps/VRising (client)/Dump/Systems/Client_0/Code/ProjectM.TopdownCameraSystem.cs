using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.CameraPresentationGroup))]
[UpdateBefore(typeof(ProjectM.HybridCameraSystem))]
[UpdateAfter(typeof(ProjectM.ZoomModifierAreaSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class TopdownCameraSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_120639046_0;
    EntityQuery __query_120639046_1;
    EntityQuery __query_120639046_2;
    EntityQuery __query_120639046_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_120639046_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TopdownCameraState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_120639046_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TopdownCamera>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_120639046_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TimeScale>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_120639046_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModeState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
