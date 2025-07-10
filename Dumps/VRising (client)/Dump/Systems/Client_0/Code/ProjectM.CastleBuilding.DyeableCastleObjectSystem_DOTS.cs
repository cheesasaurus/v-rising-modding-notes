using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(Unity.Rendering.StructuralChangePresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DyeableCastleObjectSystem_DOTS : SystemBase
{
    EntityQuery __query_839636307_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_839636307_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleBuilding.DyeableCastleObject>(),
            },
        });
        
    }
    

}
