using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.DeserializeComponentsGroup))]
[UpdateAfter(typeof(ProjectM.Network.CopySnapshotsToEntitiesSystem))]
public class UpdateWeakRefsForNewEntitiesSystem : SystemBase
{
    EntityQuery __query_832086232_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_832086232_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
