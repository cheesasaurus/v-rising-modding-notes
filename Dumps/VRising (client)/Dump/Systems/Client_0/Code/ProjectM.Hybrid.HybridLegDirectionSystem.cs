using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.SetHybridDataGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HybridLegDirectionSystem : SystemBase
{
    EntityQuery __query_1264487870_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1264487870_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.LegDirection_Shared>(),
            },
        });
        
    }
    

}
