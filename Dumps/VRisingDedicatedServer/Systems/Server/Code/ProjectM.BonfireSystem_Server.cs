using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BonfireSystem_Server : SystemBase
{
    EntityQuery __query_1818188685_0;
    EntityQuery __query_1818188685_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1818188685_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Bonfire>(),
                ComponentType.ReadOnly<ProjectM.EditableTileModel>(),
                ComponentType.ReadWrite<ProjectM.BurnContainer>(),
            },
        });
        
        __query_1818188685_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DayNightCycle>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
