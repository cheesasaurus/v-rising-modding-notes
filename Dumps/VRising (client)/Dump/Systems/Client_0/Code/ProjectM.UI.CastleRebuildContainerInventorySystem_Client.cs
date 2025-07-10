using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleRebuildContainerInventorySystem_Client : SystemBase
{
    EntityQuery __query_1784920052_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1784920052_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.GetRebuildContainerInventoryResultEvent>(),
            },
        });
        
    }
    

}
