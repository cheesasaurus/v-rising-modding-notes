using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(PresentationSystemGroup))]
public class HybridLightBakingDataSystem : SystemBase
{
    EntityQuery m_LightBakingQuery;
    EntityQuery __query_807128313_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_LightBakingQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.LightBakingOutputData>(),
                ComponentType.ReadOnly<UnityEngine.Light>(),
            },
        });
        
        __query_807128313_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.LightBakingOutputData>(),
                ComponentType.ReadOnly<UnityEngine.Light>(),
            },
        });
        
    }
    

}
