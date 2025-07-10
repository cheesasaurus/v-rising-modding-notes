using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UntrackVbloodOnDeathSystem : SystemBase
{
    EntityQuery _DeathEventQuery;
    EntityQuery __query_880714669_0;
    EntityQuery __query_880714669_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DeathEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
        __query_880714669_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
        __query_880714669_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Script_BloodAltar_TrackVBloodUnit_Shared>(),
            },
        });
        
    }
    

}
