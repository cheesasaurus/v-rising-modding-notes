using Unity.Entities;

namespace ProjectM.CastleBuilding.Rebuilding;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleRebuildSystem_Client : SystemBase
{
    EntityQuery _CastleRebuildEventQuery;
    EntityQuery __query_1847595011_0;
    EntityQuery __query_1847595011_1;
    EntityQuery __query_1847595011_2;
    EntityQuery __query_1847595011_3;
    EntityQuery __query_1847595011_4;
    EntityQuery __query_1847595011_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _CastleRebuildEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CastleRebuildCreateEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.CastleRebuildDestroyEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.CastleRebuildStateEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.CastleRebuildCommonDataEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.CastleRebuildUpdateUniqueDataEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.CastleRebuildRemoveUniqueDataEvent>(),
            },
        });
        
        __query_1847595011_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CastleRebuildCreateEvent>(),
            },
        });
        
        __query_1847595011_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CastleRebuildCommonDataEvent>(),
            },
        });
        
        __query_1847595011_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CastleRebuildUpdateUniqueDataEvent>(),
            },
        });
        
        __query_1847595011_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CastleRebuildRemoveUniqueDataEvent>(),
            },
        });
        
        __query_1847595011_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CastleRebuildStateEvent>(),
            },
        });
        
        __query_1847595011_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.CastleRebuildDestroyEvent>(),
            },
        });
        
    }
    

}
