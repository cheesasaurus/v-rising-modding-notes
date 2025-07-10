using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class VbloodGhostBuffSystem_Client_Update : ProjectM.VbloodGhostBuffSystem_Client_Base
{
    EntityQuery _GhostBuffQuery;
    EntityQuery __query_1898401279_0;
    EntityQuery __query_1898401168_0;
    EntityQuery __query_1898401168_1;
    EntityQuery __query_1898401168_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _GhostBuffQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.VbloodGhostBuff_Client>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
            },
        });
        
        __query_1898401279_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.VbloodGhostBuff_Client>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
            },
        });
        
        __query_1898401168_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Script_BloodAltar_TrackVBloodUnit_Shared>(),
            },
        });
        
        __query_1898401168_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CommonClientData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1898401168_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
