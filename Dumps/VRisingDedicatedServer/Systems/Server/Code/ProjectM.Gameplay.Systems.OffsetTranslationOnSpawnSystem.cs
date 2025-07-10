using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.GetOwnerRotationOnSpawnSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class OffsetTranslationOnSpawnSystem : SystemBase
{
    EntityQuery __query_1844768140_0;
    EntityQuery __query_1844768140_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1844768140_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.OffsetTranslationOnSpawn>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.OffsetTranslationOnSpawnBlockerSettings>(),
            },
        });
        
        __query_1844768140_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.LastTranslation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.OffsetLastTranslationOnSpawn>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
