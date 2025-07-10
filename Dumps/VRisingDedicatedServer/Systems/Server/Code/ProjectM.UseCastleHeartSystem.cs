using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UseCastleHeartSystem : SystemBase
{
    EntityQuery __query_1795194639_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1795194639_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.UseCastleHeart>(),
            },
        });
        
    }
    

}
