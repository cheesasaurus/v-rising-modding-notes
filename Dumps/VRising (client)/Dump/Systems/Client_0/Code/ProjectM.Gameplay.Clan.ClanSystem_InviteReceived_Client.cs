using Unity.Entities;

namespace ProjectM.Gameplay.Clan;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ClanSystem_InviteReceived_Client : SystemBase
{
    EntityQuery __query_369390156_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_369390156_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ClanInviteRequest_Shared>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
