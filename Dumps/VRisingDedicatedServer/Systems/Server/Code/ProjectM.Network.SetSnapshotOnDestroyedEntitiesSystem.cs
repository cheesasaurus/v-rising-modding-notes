using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[UpdateBefore(typeof(ProjectM.Network.MakePacketSystem))]
[UpdateAfter(typeof(ProjectM.Network.UpdateSnapshotsSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetSnapshotOnDestroyedEntitiesSystem : SystemBase
{
    EntityQuery _DestroyQuery;
    EntityQuery __query_1980755792_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DestroyQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkSnapshot>(),
                ComponentType.ReadOnly<ProjectM.Network.DestroyedEntity>(),
                ComponentType.ReadOnly<ProjectM.Network.NewDestroyedEntity>(),
            },
        });
        
        __query_1980755792_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
