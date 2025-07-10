using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TravelBuffUpdateLastTranslationSystem : SystemBase
{
    EntityQuery __query_615927301_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_615927301_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TravelBuff>(),
                ComponentType.ReadWrite<ProjectM.LastTranslation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
