using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class OnJewelLoadSystem : SystemBase
{
    EntityQuery _JewelLoaded;
    EntityQuery __query_1105055299_0;
    EntityQuery __query_1105055299_1;
    EntityQuery __query_1105055299_2;
    EntityQuery __query_1105055299_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _JewelLoaded = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.AbilitySpellModItem>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
        });
        
        __query_1105055299_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.AbilitySpellModItem>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
        });
        
        __query_1105055299_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.SpellModCollectionData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1105055299_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CurveCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1105055299_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ModificationsRegistry>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
