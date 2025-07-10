using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DropInventorySystem : SystemBase
{
    EntityQuery _DestroyedDropTableQuery;
    EntityQuery _DestroyInventoryOnDestroyQuery;
    EntityQuery __query_2070481580_0;
    EntityQuery __query_2070481580_1;
    EntityQuery __query_2070481580_2;
    EntityQuery __query_2070481580_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DestroyedDropTableQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.DropTable>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        _DestroyInventoryOnDestroyQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DestroyData>(),
                ComponentType.ReadOnly<ProjectM.InventoryInstanceElement>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_2070481580_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Shared.DropTableBuffer>(),
                ComponentType.ReadOnly<ProjectM.Shared.DropTableOnDestroy>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_2070481580_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Shared.DropTableBuffer>(),
                ComponentType.ReadOnly<ProjectM.Shared.DropTableOnSalvageDestroy>(),
                ComponentType.ReadOnly<ProjectM.Shared.WasSalvaged>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_2070481580_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DestroyData>(),
                ComponentType.ReadOnly<ProjectM.InventoryInstanceElement>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_2070481580_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.RelicDropped>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
