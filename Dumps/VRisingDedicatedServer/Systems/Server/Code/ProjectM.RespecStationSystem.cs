using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RespecStationSystem : SystemBase
{
    EntityQuery _ResetSchoolEventQuery;
    EntityQuery __query_1533704116_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ResetSchoolEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.RespecStationEvents.ResetSchoolEvent>(),
            },
        });
        
        __query_1533704116_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.RespecStationEvents.ResetSchoolEvent>(),
            },
        });
        
    }
    

}
