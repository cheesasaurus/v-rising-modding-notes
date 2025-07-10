using Unity.Entities;

[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TutorialSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_254750264_0;
    EntityQuery __query_254750264_1;
    EntityQuery __query_254750264_2;
    EntityQuery __query_254750264_3;
    EntityQuery __query_254750264_4;
    EntityQuery __query_254750264_5;
    EntityQuery __query_254750264_6;
    EntityQuery __query_254750264_7;
    EntityQuery __query_254750264_8;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_254750264_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UICanvasBase>(),
            },
        });
        
        __query_254750264_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.InventorySubMenu>(),
            },
        });
        
        __query_254750264_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.FullscreenMenu>(),
            },
        });
        
        __query_254750264_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPreCastFinishedEvent>(),
            },
        });
        
        __query_254750264_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TutorialPointPosition>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_254750264_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_254750264_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_254750264_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HUD.TerritoryBuildTriggerComponent>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_254750264_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TopdownCameraState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
