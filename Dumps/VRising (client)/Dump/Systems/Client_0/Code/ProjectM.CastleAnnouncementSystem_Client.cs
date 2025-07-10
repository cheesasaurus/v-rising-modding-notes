using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleAnnouncementSystem_Client : SystemBase
{
    EntityQuery _EventQueryBreach;
    EntityQuery _EventQueryAttacked;
    EntityQuery _EventQuerySiegeMaking;
    EntityQuery __query_134574630_0;
    EntityQuery __query_134574630_1;
    EntityQuery __query_134574630_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQueryBreach = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CastleWallBreachedEvent>(),
            },
        });
        
        _EventQueryAttacked = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CastleAttackedEvent>(),
            },
        });
        
        _EventQuerySiegeMaking = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NewSiegeWeapon>(),
            },
        });
        
        __query_134574630_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CastleWallBreachedEvent>(),
            },
        });
        
        __query_134574630_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NewSiegeWeapon>(),
            },
        });
        
        __query_134574630_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CastleAttackedEvent>(),
            },
        });
        
    }
    

}
