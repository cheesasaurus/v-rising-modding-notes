using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MusicPlayerStationMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _Query;
    EntityQuery __query_2097689769_0;
    EntityQuery __query_2097689769_1;
    EntityQuery __query_2097689769_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.MusicPlayerStationMenu>(),
            },
        });
        
        __query_2097689769_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.MusicPlayerStationMenu.InitData>(),
            },
        });
        
        __query_2097689769_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.MusicPlayerStationMenu>(),
            },
        });
        
        __query_2097689769_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationTrack_Shared>(),
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationTrack_Client>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.OutdatedPrefab>(),
            },
        });
        
    }
    

}
