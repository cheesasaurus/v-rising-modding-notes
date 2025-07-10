using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.MoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TeleportPlayerLocationSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1285778122_0;
    EntityQuery __query_1285778122_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.TeleportPlayerToLocationDebugEvent>(),
            },
        });
        
        __query_1285778122_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.TeleportPlayerToLocationDebugEvent>(),
            },
        });
        
        __query_1285778122_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
