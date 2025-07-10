using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ArenaSummaryHUDSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery _ActiveArenaQuery;
    EntityQuery __query_1813865526_0;
    EntityQuery __query_1813865526_1;
    EntityQuery __query_1813865526_2;
    EntityQuery __query_1813865526_3;
    EntityQuery __query_1813865526_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ActiveArenaQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleActiveArenaSingleton>(),
            },
        });
        
        __query_1813865526_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleActiveArenaSingleton>(),
            },
        });
        
        __query_1813865526_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildMode>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1813865526_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestHUDSettingsManaged>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1813865526_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1813865526_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CommonClientData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
