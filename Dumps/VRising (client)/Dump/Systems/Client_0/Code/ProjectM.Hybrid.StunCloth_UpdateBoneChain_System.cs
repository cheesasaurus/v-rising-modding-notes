using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.StunCloth_GetBoneChain_System))]
[RequireMatchingQueriesForUpdateAttribute]
public class StunCloth_UpdateBoneChain_System : SystemBase
{
    EntityQuery __query_501411890_0;
    EntityQuery __query_501411890_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_501411890_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.BoneChain_Data>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.BoneChainSegment_Data>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.BoneChainStick_Data>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.StunCloth_Collider_Data>(),
            },
        });
        
        __query_501411890_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
