using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RagdollDriverSystem_Destroy : SystemBase
{
    EntityQuery __query_501954832_0;
    EntityQuery __query_501954832_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_501954832_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridRagdollComponent>(),
            },
        });
        
        __query_501954832_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RagdollDriver>(),
            },
        });
        
    }
    

}
