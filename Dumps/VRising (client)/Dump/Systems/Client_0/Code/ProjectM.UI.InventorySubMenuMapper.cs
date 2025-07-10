using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InventorySubMenuMapper : SystemBase
{
    EntityQuery _Query;
    EntityQuery _LocalPlayerQuery;
    EntityQuery __query_641047155_0;
    EntityQuery __query_641047155_1;
    EntityQuery __query_641047155_2;
    EntityQuery __query_641047155_3;
    EntityQuery __query_641047155_4;
    EntityQuery __query_641047155_5;
    EntityQuery __query_641047155_6;
    EntityQuery __query_641047155_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.InventorySubMenu>(),
            },
        });
        
        _LocalPlayerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Controller>(),
                ComponentType.ReadWrite<ProjectM.Network.User>(),
                ComponentType.ReadWrite<ProjectM.Network.LocalUser>(),
            },
        });
        
        __query_641047155_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.InventorySubMenu>(),
            },
        });
        
        __query_641047155_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ShowOnBuffBar>(),
            },
        });
        
        __query_641047155_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.WeaponCoating.Coatable>(),
                ComponentType.ReadOnly<ProjectM.Equippable>(),
            },
        });
        
        __query_641047155_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.SpellModCollectionData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_641047155_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CurveCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_641047155_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_641047155_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Transmog.TransmogModeSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_641047155_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TopdownCameraState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
