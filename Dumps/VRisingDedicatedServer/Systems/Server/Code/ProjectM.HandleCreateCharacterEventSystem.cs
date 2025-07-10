using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HandleCreateCharacterEventSystem : SystemBase
{
    EntityQuery _CreateCharacterEventQuery;
    EntityQuery __query_276119541_0;
    EntityQuery __query_276119541_1;
    EntityQuery __query_276119541_2;
    EntityQuery __query_276119541_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _CreateCharacterEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.CreateCharacterEvent>(),
            },
        });
        
        __query_276119541_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
        });
        
        __query_276119541_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ConnectedUser>(),
            },
        });
        
        __query_276119541_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_276119541_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
