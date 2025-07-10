using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateBuffsBuffer_Destroy : SystemBase
{
    EntityQuery __query_401358717_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_401358717_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
