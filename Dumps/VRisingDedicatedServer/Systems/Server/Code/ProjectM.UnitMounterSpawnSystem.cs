using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UnitMounterSpawnSystem : SystemBase
{
    EntityQuery __query_2022017603_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2022017603_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadWrite<ProjectM.UnitMounter>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
