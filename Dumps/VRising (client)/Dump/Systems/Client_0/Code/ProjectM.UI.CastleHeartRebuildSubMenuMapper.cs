using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleHeartRebuildSubMenuMapper : SystemBase
{
    EntityQuery _MenuQuery;
    EntityQuery __query_1333132788_0;
    EntityQuery __query_1333132788_1;
    EntityQuery __query_1333132788_2;
    EntityQuery __query_1333132788_3;
    EntityQuery __query_1333132788_4;
    EntityQuery __query_1333132788_5;
    EntityQuery __query_1333132788_6;
    EntityQuery __query_1333132788_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MenuQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.CastleHeartRebuildSubMenu.State>(),
                ComponentType.ReadOnly<ProjectM.UI.CastleHeartRebuildSubMenu>(),
            },
        });
        
        __query_1333132788_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.CastleHeartRebuildSubMenu.State>(),
                ComponentType.ReadOnly<ProjectM.UI.CastleHeartRebuildSubMenu>(),
            },
        });
        
        __query_1333132788_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.CastleHeartRebuildSubMenu>(),
            },
        });
        
        __query_1333132788_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.Rebuilding.CastleRebuildRegistry>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1333132788_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapZoneCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1333132788_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1333132788_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1333132788_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TimeZonedDateTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1333132788_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
