using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.EarlyUpdateGroup), OrderFirst = true)]
public class CommonClientDataSystem : SystemBase
{
    EntityQuery __query_1840110770_0;
    EntityQuery __query_1840110770_1;
    EntityQuery __query_1840110770_2;
    EntityQuery __query_1840110770_3;
    EntityQuery __query_1840110770_4;
    EntityQuery __query_1840110770_5;
    EntityQuery __query_1840110770_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1840110770_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1840110770_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1840110770_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalControlled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1840110770_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1840110770_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1840110770_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1840110770_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapZoneCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
