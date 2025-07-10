using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ScaleWithBloodEfficiencySystem : SystemBase
{
    EntityQuery __query_547431279_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_547431279_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Gameplay.Scripting.ScaleWithBloodEfficiency>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
