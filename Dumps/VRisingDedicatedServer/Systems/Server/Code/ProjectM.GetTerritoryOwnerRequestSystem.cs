using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class GetTerritoryOwnerRequestSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery __query_832539417_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.GetTerritoryOwnerRequestEvent>(),
            },
        });
        
        __query_832539417_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.GetTerritoryOwnerRequestEvent>(),
            },
        });
        
    }
    

}
