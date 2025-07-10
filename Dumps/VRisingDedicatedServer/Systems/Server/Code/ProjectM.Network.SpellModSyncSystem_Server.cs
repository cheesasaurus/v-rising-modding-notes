using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.BeforeSerializeBarrierGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpellModSyncSystem_Server : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1719319440_0;
    EntityQuery __query_1719319440_1;
    EntityQuery __query_1719319440_2;
    EntityQuery __query_1719319440_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.SpellModSetAckEvent>(),
            },
        });
        
        __query_1719319440_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.SpellModSetAckEvent>(),
            },
        });
        
        __query_1719319440_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UserConnectionChangedEvent>(),
            },
        });
        
        __query_1719319440_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.SpellModSyncSystem_ServerData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1719319440_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.SpellModSyncSystem_ServerData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
