using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[UpdateBefore(typeof(ProjectM.UI.MapMenuMapper))]
[RequireMatchingQueriesForUpdateAttribute]
public class TerritoryOwnerCacheSystem : SystemBase
{
    EntityQuery _Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.GetTerritoryOwnerResponseEvent>(),
            },
        });
        
    }
    

}
