using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AfterLoadRemoveDisabledFromRoomSystem : SystemBase
{
    EntityQuery _Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleRoofOrnaments>(),
                ComponentType.ReadOnly<ProjectM.DisableWhenNoPlayersInRange>(),
                ComponentType.ReadOnly<ProjectM.WasDisabledBeforeNoPlayersInRange>(),
                ComponentType.ReadOnly<ProjectM.DisabledDueToNoPlayersInRange>(),
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
        });
        
    }
    

}
