using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ActiveLightningRodSequenceSystem : SystemBase
{
    EntityQuery __query_1489148990_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1489148990_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.LightningRodStation>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
