using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.PlayCommandSystemGroup))]
[UpdateBefore(typeof(ProjectM.Network.PlayCommandsSystem_Server))]
[RequireMatchingQueriesForUpdateAttribute]
public class InputCommandAbilityStateHistorySystem_Server : ProjectM.Network.CommandUtility.InputCommandAbilityStateHistorySystem_Base
{
    EntityQuery _Query;
    EntityQuery __query_1019329196_0;
    EntityQuery __query_1019329196_1;
    EntityQuery __query_1019329196_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.InputCommandDataProxy>(),
                ComponentType.ReadWrite<ProjectM.Network.InputCommandStateHistoryBufferElement>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
        __query_1019329196_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.InputCommandDataProxy>(),
                ComponentType.ReadWrite<ProjectM.Network.InputCommandStateHistoryBufferElement>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
        __query_1019329196_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.WorldFrame>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1019329196_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
