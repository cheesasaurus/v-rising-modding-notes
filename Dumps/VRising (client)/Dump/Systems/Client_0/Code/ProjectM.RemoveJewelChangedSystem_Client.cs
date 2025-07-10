using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RemoveJewelChangedSystem_Client : ProjectM.RemoveJewelChangedSystemBase
{
    EntityQuery __query_1105055077_0;
    EntityQuery __query_1105055077_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1105055077_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.JewelChanged>(),
            },
        });
        
        __query_1105055077_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.LegendaryItemChangedEvent>(),
            },
        });
        
    }
    

}
