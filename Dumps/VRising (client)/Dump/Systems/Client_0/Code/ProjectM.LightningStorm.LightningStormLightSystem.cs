using Unity.Entities;

namespace ProjectM.LightningStorm;


[UpdateInGroup(typeof(PresentationSystemGroup))]
public class LightningStormLightSystem : SystemBase
{
    EntityQuery __query_257587597_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_257587597_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridCameraData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
