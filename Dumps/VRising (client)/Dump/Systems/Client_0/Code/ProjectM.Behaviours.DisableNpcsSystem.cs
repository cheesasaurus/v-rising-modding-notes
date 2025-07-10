using Unity.Entities;

namespace ProjectM.Behaviours;


[UpdateInGroup(typeof(ProjectM.EarlyUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DisableNpcsSystem : SystemBase
{
    EntityQuery __query_112587454_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_112587454_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.EntityInput>(),
                ComponentType.ReadOnly<ProjectM.MoveEntity>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ControlledBy>(),
            },
        });
        
    }
    

}
