using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.BuildModeGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class BuildModeCloseSystem : SystemBase
{
    EntityQuery _ExitBuildModeQuery;
    EntityQuery __query_1808265850_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ExitBuildModeQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.ExitBuildModeEvent>(),
            },
        });
        
        __query_1808265850_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.ExitBuildModeEvent>(),
            },
        });
        
    }
    

}
