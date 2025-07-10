using Unity.Entities;

namespace ProjectM.Physics;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class PickingSystem : SystemBase
{
    EntityQuery __query_1630439037_0;
    EntityQuery __query_1630439037_1;
    EntityQuery __query_1630439037_2;
    EntityQuery __query_1630439037_3;
    EntityQuery __query_1630439037_4;
    EntityQuery __query_1630439037_5;
    EntityQuery __query_1630439037_6;
    EntityQuery __query_1630439037_7;
    EntityQuery __query_1630439037_8;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1630439037_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraUser>(),
            },
        });
        
        __query_1630439037_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Picker>(),
            },
        });
        
        __query_1630439037_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CursorPosition>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1630439037_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1630439037_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.FadeTargetsSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1630439037_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.CurrentFadingDataSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1630439037_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EnableGamepadCursor>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1630439037_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildMode>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1630439037_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Physics.PickingSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
