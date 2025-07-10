using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup), OrderFirst = true)]
[UpdateAfter(typeof(ProjectM.SpawnCastleTeamSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleTeamConnectionSystem : SystemBase
{
    EntityQuery __query_523473556_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_523473556_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadWrite<ProjectM.TeamReference>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
            },
        });
        
    }
    

}
