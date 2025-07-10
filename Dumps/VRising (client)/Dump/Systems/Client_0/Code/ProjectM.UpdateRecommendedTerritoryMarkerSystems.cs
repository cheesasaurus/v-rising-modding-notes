using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateRecommendedTerritoryMarkerSystems : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_482434305_0;
    EntityQuery __query_482434305_1;
    EntityQuery __query_482434305_2;
    EntityQuery __query_482434305_3;
    EntityQuery __query_482434305_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TutorialMarker>(),
            },
        });
        
        __query_482434305_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritory>(),
                ComponentType.ReadOnly<ProjectM.Terrain.MapZoneData>(),
            },
        });
        
        __query_482434305_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ScreenEdgeIcon>(),
                ComponentType.ReadWrite<ProjectM.MapIconPosition>(),
                ComponentType.ReadOnly<ProjectM.TutorialMarker>(),
            },
        });
        
        __query_482434305_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HUD.TerritoryBuildTriggerComponent>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_482434305_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CommonClientData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_482434305_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritoryManager>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
