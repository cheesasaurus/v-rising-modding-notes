using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ActiveSalvageSequenceSystem : SystemBase
{
    EntityQuery __query_1403192201_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1403192201_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Salvagestation>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
