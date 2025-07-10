using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleRepairBuffDestroySystem : SystemBase
{
    EntityQuery __query_1268645191_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1268645191_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.DamagedEditableTile>(),
            },
        });
        
    }
    

}
