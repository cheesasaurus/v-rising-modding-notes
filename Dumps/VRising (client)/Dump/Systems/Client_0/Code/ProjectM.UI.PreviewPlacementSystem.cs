using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class PreviewPlacementSystem : SystemBase
{
    EntityQuery __query_2124516653_0;
    EntityQuery __query_2124516653_1;
    EntityQuery __query_2124516653_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2124516653_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PreviewPlacementBuff>(),
            },
        });
        
        __query_2124516653_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2124516653_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.EditTileModelSelection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
