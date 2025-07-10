using Unity.Entities;

namespace Network.Systems;


[UpdateInGroup(typeof(ProjectM.PlayCommandSystemGroup))]
[UpdateAfter(typeof(ProjectM.Network.PlayCommandsSystem_Server))]
[RequireMatchingQueriesForUpdateAttribute]
public class TeleportIncorrectPositionSystem : SystemBase
{
    EntityQuery __query_524969957_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_524969957_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
