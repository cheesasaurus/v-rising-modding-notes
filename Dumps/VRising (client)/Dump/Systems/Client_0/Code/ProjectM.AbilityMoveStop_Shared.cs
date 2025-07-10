using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityMoveGroup), OrderLast = true)]
public class AbilityMoveStop_Shared : SystemBase
{
    EntityQuery __query_335314837_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_335314837_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CurrentCastsSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
