using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetInputGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class GameplayInputSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery _EntityInputQuery;
    EntityQuery __query_1629686301_0;
    EntityQuery __query_1629686301_1;
    EntityQuery __query_1629686301_2;
    EntityQuery __query_1629686301_3;
    EntityQuery __query_1629686301_4;
    EntityQuery __query_1629686301_5;
    EntityQuery __query_1629686301_6;
    EntityQuery __query_1629686301_7;
    EntityQuery __query_1629686301_8;
    EntityQuery __query_1629686301_9;
    EntityQuery __query_1629686301_10;
    EntityQuery __query_1629686301_11;
    EntityQuery __query_1629686301_12;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EntityInputQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraUser>(),
                ComponentType.ReadOnly<ProjectM.EntityInput>(),
                ComponentType.ReadOnly<ProjectM.EntityAbilityInput>(),
                ComponentType.ReadWrite<ProjectM.Controller>(),
                ComponentType.ReadWrite<ProjectM.UserFocusPoint>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        __query_1629686301_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraUser>(),
                ComponentType.ReadOnly<ProjectM.EntityInput>(),
                ComponentType.ReadOnly<ProjectM.EntityAbilityInput>(),
                ComponentType.ReadWrite<ProjectM.Controller>(),
                ComponentType.ReadWrite<ProjectM.UserFocusPoint>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        __query_1629686301_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CommonClientData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1629686301_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.GameplayInputSystem.State>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1629686301_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Replays.ClientReplayPlayerEnabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1629686301_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1629686301_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1629686301_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CursorPosition>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1629686301_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ResetMovementCameraDirection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1629686301_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildMode>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1629686301_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModeState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1629686301_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1629686301_11 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModePlacementOperation>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1629686301_12 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GameplayInputSystem.State>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
