using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CompleteAchievementSystem : SystemBase
{
    EntityQuery __query_1557184233_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1557184233_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ProgressAchievementEvent>(),
            },
        });
        
    }
    

}
