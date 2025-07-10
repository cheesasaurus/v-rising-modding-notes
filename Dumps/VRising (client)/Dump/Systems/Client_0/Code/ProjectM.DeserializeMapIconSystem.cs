using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeserializeGroup))]
public class DeserializeMapIconSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1690774726_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapIconPosition>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1690774726_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapIconPosition>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
