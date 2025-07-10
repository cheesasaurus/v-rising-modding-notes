using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[UpdateAfter(typeof(ProjectM.AttachSystem_ReactToPersistenceLoad))]
[RequireMatchingQueriesForUpdateAttribute]
public class RepairBrokenEquippedSystem : SystemBase
{
    EntityQuery __query_506415066_0;
    EntityQuery __query_506415066_1;
    EntityQuery __query_506415066_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_506415066_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.WeaponLevel>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_506415066_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpellLevel>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_506415066_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
                ComponentType.ReadOnly<ProjectM.AttachedBuffer>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
