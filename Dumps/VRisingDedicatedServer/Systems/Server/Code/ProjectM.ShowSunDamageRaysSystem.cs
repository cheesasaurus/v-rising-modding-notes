using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ShowSunDamageRaysSystem : SystemBase
{
    EntityQuery __query_2008867829_0;
    EntityQuery __query_2008867829_1;
    EntityQuery __query_2008867829_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2008867829_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TakeDamageInSun>(),
                ComponentType.ReadOnly<ProjectM.Health>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        __query_2008867829_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sun>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2008867829_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
