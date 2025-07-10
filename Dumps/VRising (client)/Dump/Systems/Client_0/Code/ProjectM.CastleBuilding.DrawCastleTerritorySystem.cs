using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DrawCastleTerritorySystem : SystemBase
{
    EntityQuery __query_1326312272_0;
    EntityQuery __query_1326312272_1;
    EntityQuery __query_1326312272_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1326312272_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritory>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritoryBlocks>(),
            },
        });
        
        __query_1326312272_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModeState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1326312272_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CursorPosition>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
