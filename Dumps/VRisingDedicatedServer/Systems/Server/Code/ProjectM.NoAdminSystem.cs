using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class NoAdminSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery _AdminsQuery;
    EntityQuery __query_1915659636_0;
    EntityQuery __query_1915659636_1;
    EntityQuery __query_1915659636_2;
    EntityQuery __query_1915659636_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.DeauthAdminEvent>(),
            },
        });
        
        _AdminsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AdminUser>(),
            },
        });
        
        __query_1915659636_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.DeauthAdminEvent>(),
            },
        });
        
        __query_1915659636_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerDebugLogs>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1915659636_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerDebugViewData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1915659636_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRuntimeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
