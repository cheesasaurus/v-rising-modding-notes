using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.CharacterHUDGroup))]
public class TargetInfoParentSystem : SystemBase
{
    EntityQuery _HideHUDBuffQuery;
    EntityQuery _TargetUnitQuery;
    EntityQuery _TargetStructureQuery;
    EntityQuery __query_643934152_0;
    EntityQuery __query_643934152_1;
    EntityQuery __query_643934152_2;
    EntityQuery __query_643934152_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _HideHUDBuffQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.HideTargetHUD>(),
            },
        });
        
        _TargetUnitQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CheckOnScreen>(),
                ComponentType.ReadOnly<ProjectM.UI.HealthBarHUD>(),
                ComponentType.ReadOnly<ProjectM.CharacterHUD>(),
                ComponentType.ReadOnly<ProjectM.Health>(),
                ComponentType.ReadOnly<ProjectM.Team>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        _TargetStructureQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Team>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        __query_643934152_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.AbsorbBuff>(),
            },
        });
        
        __query_643934152_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestHUDSettingsManaged>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_643934152_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildMode>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_643934152_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UserInfoBufferSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
