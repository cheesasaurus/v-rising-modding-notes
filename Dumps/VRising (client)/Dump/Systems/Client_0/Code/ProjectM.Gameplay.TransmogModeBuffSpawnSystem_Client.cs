using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TransmogModeBuffSpawnSystem_Client : SystemBase
{
    EntityQuery __query_1329016584_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1329016584_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.Network.ModifyRotation>(),
                ComponentType.ReadOnly<ProjectM.Transmog.TransmogModeBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
