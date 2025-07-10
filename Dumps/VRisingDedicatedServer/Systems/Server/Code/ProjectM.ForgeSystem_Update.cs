using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ForgeSystem_Update : SystemBase
{
    EntityQuery __query_1536473550_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1536473550_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Forge_Shared>(),
                ComponentType.ReadOnly<ProjectM.CastleWorkstation>(),
                ComponentType.ReadOnly<ProjectM.StationBonusBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
