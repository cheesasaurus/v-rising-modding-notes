using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
public class CastleHeartInitializeRaidStateSystem : SystemBase
{
    EntityQuery __query_1288933481_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1288933481_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
        });
        
    }
    

}
