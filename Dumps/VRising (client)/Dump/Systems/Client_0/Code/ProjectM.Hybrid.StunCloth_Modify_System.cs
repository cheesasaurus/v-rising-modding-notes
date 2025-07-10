using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.HybridModelSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class StunCloth_Modify_System : SystemBase
{
    EntityQuery __query_93712691_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_93712691_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadWrite<ProjectM.ModifyStunCloth_Data>(),
            },
        });
        
    }
    

}
