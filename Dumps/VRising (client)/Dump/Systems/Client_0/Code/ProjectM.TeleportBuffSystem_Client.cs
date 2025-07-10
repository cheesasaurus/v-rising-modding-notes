using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.MoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TeleportBuffSystem_Client : SystemBase
{
    EntityQuery __query_2122398927_0;
    EntityQuery __query_2122398927_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2122398927_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.FadeToBlack_Manual>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadWrite<ProjectM.TeleportBuff>(),
            },
        });
        
        __query_2122398927_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.TeleportBuff>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.FadeToBlack_Manual>(),
            },
        });
        
    }
    

}
