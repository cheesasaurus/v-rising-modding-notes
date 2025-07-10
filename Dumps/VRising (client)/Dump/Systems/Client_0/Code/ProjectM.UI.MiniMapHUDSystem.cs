using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[UpdateAfter(typeof(ProjectM.UI.MapZonePolygonUIMeshSystem))]
public class MiniMapHUDSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_1777003595_0;
    EntityQuery __query_1777003595_1;
    EntityQuery __query_1777003595_2;
    EntityQuery __query_1777003595_3;
    EntityQuery __query_1777003595_4;
    EntityQuery __query_1777003595_5;
    EntityQuery __query_1777003595_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1777003595_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritory>(),
                ComponentType.ReadOnly<ProjectM.Terrain.MapZoneData>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritoryTiles>(),
            },
        });
        
        __query_1777003595_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UiPolygonMesh>(),
                ComponentType.ReadOnly<ProjectM.Terrain.MapZoneData>(),
            },
        });
        
        __query_1777003595_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.WarEvents.WarEvent_NetworkedGate>(),
            },
        });
        
        __query_1777003595_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PathRecorder>(),
                ComponentType.ReadOnly<ProjectM.PathRecorderEntry>(),
            },
        });
        
        __query_1777003595_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapIconData>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
            },
        });
        
        __query_1777003595_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritoryManager>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1777003595_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
