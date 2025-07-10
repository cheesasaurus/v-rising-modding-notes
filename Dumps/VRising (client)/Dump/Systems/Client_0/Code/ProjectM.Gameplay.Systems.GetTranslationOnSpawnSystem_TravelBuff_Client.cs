using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
[RequireMatchingQueriesForUpdateAttribute]
public class GetTranslationOnSpawnSystem_TravelBuff_Client : SystemBase
{
    EntityQuery __query_1844768080_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1844768080_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GetTranslationOnSpawn>(),
                ComponentType.ReadOnly<ProjectM.TravelBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
