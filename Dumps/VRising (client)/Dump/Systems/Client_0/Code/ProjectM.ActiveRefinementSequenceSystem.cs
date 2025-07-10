using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ActiveRefinementSequenceSystem : SystemBase
{
    EntityQuery __query_1034307272_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1034307272_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Refinementstation>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
