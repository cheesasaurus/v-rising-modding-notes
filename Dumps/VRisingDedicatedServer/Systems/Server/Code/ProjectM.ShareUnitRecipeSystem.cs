using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ShareUnitRecipeSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery __query_2099431847_0;
    EntityQuery __query_2099431847_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ShareUnitspawnerRecipesEvent>(),
            },
        });
        
        __query_2099431847_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ShareUnitspawnerRecipesEvent>(),
            },
        });
        
        __query_2099431847_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
