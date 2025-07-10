using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[UpdateBefore(typeof(ProjectM.DropInventorySystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class ServantReactToDestroySystem : SystemBase
{
    EntityQuery __query_1849383071_0;
    EntityQuery __query_1849383071_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1849383071_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServantConnectedCoffin>(),
                ComponentType.ReadOnly<ProjectM.ServantEquipment>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_1849383071_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServantCoffinstation>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
