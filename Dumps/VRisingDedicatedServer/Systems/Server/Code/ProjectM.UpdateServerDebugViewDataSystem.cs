using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateServerDebugViewDataSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery _AllServerEntitiesDisabled;
    EntityQuery _AllServerEntitiesEnabled;
    EntityQuery _AiEnabledQuery;
    EntityQuery _AllServerUsers;
    EntityQuery __query_1563709620_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ServerDebugViewData>(),
            },
        });
        
        _AllServerEntitiesDisabled = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
        });
        
        _AllServerEntitiesEnabled = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
        });
        
        _AiEnabledQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AiMove_Server>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        _AllServerUsers = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
        });
        
        __query_1563709620_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ServerDebugViewData>(),
            },
        });
        
    }
    

}
