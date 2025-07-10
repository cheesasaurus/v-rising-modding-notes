using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ModifyInventorySizeEventSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_618362235_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ModifyInventorySizeEvent>(),
            },
        });
        
        __query_618362235_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ModifyInventorySizeEvent>(),
            },
        });
        
    }
    

}
