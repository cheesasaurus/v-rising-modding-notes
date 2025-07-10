using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class GamepadCursorSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_753167736_0;
    EntityQuery __query_753167736_1;
    EntityQuery __query_753167736_2;
    EntityQuery __query_753167736_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_753167736_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CursorPosition>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_753167736_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridCameraData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_753167736_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModeState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_753167736_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
