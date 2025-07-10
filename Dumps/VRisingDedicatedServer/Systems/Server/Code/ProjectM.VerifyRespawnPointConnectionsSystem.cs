using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class VerifyRespawnPointConnectionsSystem : SystemBase
{
    EntityQuery __query_1150277271_0;
    EntityQuery __query_1150277271_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1150277271_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RespawnPoint>(),
                ComponentType.ReadOnly<ProjectM.Team>(),
            },
        });
        
        __query_1150277271_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Team>(),
                ComponentType.ReadOnly<ProjectM.RespawnPointOwnerBuffer>(),
            },
        });
        
    }
    

}
