using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UIGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class HandleJewelEquippedResponseSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_496356691_0;
    EntityQuery __query_496356691_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.JewelEquippedResponseEvent>(),
            },
        });
        
        __query_496356691_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UICanvasBase>(),
            },
        });
        
        __query_496356691_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
