using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(Unity.Rendering.EntitiesGraphicsSystem))]
public class MatrixPreviousSystem : SystemBase
{
    EntityQuery m_GroupPrev;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_GroupPrev = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Rendering.BuiltinMaterialPropertyUnity_MatrixPreviousM>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.SkipBuiltinMaterialPropertyUnity_MatrixPreviousMUpdate>(),
            },
            Options = EntityQueryOptions.FilterWriteGroup,
        });
        
    }
    

}
