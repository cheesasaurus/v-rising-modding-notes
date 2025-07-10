using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ForceJoinClanEventSystem_Server : SystemBase
{
    EntityQuery _ByClosestToPositionQuery;
    EntityQuery _ByPlayerNameQuery;
    EntityQuery _UserQuery;
    EntityQuery __query_1636139754_0;
    EntityQuery __query_1636139754_1;
    EntityQuery __query_1636139754_2;
    EntityQuery __query_1636139754_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ByClosestToPositionQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForceJoinClanEvents.Request_ByClosestToPosition>(),
            },
        });
        
        _ByPlayerNameQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForceJoinClanEvents.Request_ByPlayerName>(),
            },
        });
        
        _UserQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
        });
        
        __query_1636139754_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForceJoinClanEvents.Request_ByClosestToPosition>(),
            },
        });
        
        __query_1636139754_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForceJoinClanEvents.Request_ByPlayerName>(),
            },
        });
        
        __query_1636139754_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1636139754_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
