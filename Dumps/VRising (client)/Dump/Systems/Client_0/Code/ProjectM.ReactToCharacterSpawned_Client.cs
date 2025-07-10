using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ReactToCharacterSpawned_Client : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1631932714_0;
    EntityQuery __query_1631932714_1;
    EntityQuery __query_1631932714_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CharacterHasRespawnedEvent>(),
            },
        });
        
        __query_1631932714_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CharacterHasRespawnedEvent>(),
            },
        });
        
        __query_1631932714_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TopdownCameraState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1631932714_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TopdownCameraState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
