using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class ServantMissionUpdateSystem : SystemBase
{
    EntityQuery __query_262912642_0;
    EntityQuery __query_262912642_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_262912642_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.ActiveServantMission>(),
            },
        });
        
        __query_262912642_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.RelicDropped>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
