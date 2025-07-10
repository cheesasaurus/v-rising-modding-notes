using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
public class ShaderCollectionSystem : SystemBase
{
    EntityQuery __query_273458629_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_273458629_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ShaderCollection>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
    }
    

}
