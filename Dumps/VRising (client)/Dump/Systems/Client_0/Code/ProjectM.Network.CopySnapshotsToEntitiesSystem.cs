using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.DeserializeComponentsGroup))]
public class CopySnapshotsToEntitiesSystem : SystemBase
{
    EntityQuery __query_1565359926_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1565359926_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
