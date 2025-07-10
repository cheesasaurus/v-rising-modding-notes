using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.MoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TeleportSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1285777444_0;
    EntityQuery __query_1285777444_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.TeleportDebugEvent>(),
            },
        });
        
        __query_1285777444_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityCategory>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        __query_1285777444_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
