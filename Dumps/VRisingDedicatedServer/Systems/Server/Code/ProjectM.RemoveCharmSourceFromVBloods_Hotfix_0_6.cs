using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[UpdateAfter(typeof(ProjectM.AttachSystem_ReactToPersistenceLoad))]
[RequireMatchingQueriesForUpdateAttribute]
public class RemoveCharmSourceFromVBloods_Hotfix_0_6 : SystemBase
{
    EntityQuery __query_1133533335_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1133533335_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VBloodUnit>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.CharmSource>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
