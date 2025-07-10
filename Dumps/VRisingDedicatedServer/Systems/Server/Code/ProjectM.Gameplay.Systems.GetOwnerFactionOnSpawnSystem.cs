using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
[RequireMatchingQueriesForUpdateAttribute]
public class GetOwnerFactionOnSpawnSystem : SystemBase
{
    EntityQuery __query_1156247801_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1156247801_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.GetOwnerFactionOnSpawn>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
