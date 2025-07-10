using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[UpdateAfter(typeof(ProjectM.RegisterRenderMeshPrefabsSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class PrefabTextureStreamingInitializationSystem : SystemBase
{
    EntityQuery __query_1820907327_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1820907327_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefab>(),
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
