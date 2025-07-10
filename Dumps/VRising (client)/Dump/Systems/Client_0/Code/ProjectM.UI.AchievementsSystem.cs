using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class AchievementsSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery _NewPrefabsRegisteredQuery;
    EntityQuery __query_92496171_0;
    EntityQuery __query_92496171_1;
    EntityQuery __query_92496171_2;
    EntityQuery __query_92496171_3;
    EntityQuery __query_92496171_4;
    EntityQuery __query_92496171_5;
    EntityQuery __query_92496171_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _NewPrefabsRegisteredQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.NewPrefabsRegisteredEvent>(),
            },
        });
        
        __query_92496171_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.AnnouncementHUDParent>(),
            },
        });
        
        __query_92496171_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VBloodConsumeSource>(),
                ComponentType.ReadOnly<ProjectM.Hideable>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
            },
        });
        
        __query_92496171_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VBloodConsumeSource>(),
                ComponentType.ReadOnly<ProjectM.Hideable>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        __query_92496171_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Script_BloodAltar_TrackVBloodUnit_Shared>(),
            },
        });
        
        __query_92496171_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.VbloodGhostBuff_Shared>(),
            },
        });
        
        __query_92496171_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TutorialMarker>(),
            },
        });
        
        __query_92496171_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HUD.TerritoryBuildTriggerComponent>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
