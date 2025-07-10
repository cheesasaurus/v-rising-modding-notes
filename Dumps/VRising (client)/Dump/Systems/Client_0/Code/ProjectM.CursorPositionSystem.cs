using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(InitializationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CursorPositionSystem : SystemBase
{
    EntityQuery __query_1498525450_0;
    EntityQuery __query_1498525450_1;
    EntityQuery __query_1498525450_2;
    EntityQuery __query_1498525450_3;
    EntityQuery __query_1498525450_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1498525450_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraUser>(),
                ComponentType.ReadOnly<ProjectM.Controller>(),
            },
        });
        
        __query_1498525450_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1498525450_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.FadeTargetsSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1498525450_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.CurrentFadingDataSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1498525450_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CursorPosition>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
