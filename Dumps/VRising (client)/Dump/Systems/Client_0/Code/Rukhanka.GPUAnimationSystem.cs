using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaDeformationSystemGroup))]
[UpdateBefore(typeof(Rukhanka.MeshDeformationSystem))]
[UpdateAfter(typeof(Rukhanka.SkinnedMeshPreparationSystem))]
public class GPUAnimationSystem : SystemBase
{
    EntityQuery gpuAnimatedRigQuery;
    EntityQuery __query_1698666241_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        // Error processing gpuAnimatedRigQuery
        // 
        // Il2CppInterop.Runtime.Il2CppException: System.NullReferenceException: Object reference not set to an instance of an object.
        //  --- BEGIN IL2CPP STACK TRACE ---
        //  System.NullReferenceException: Object reference not set to an instance of an object.
        //    at Unity.Entities.EntityQuery.get_IsCacheValid () [0x00000] in <00000000000000000000000000000000>:0 
        //  --- END IL2CPP STACK TRACE ---
        //  
        //     at Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(IntPtr returnedException) in C:\Work\-\VRisingBepInExBuild\Il2CppInterop\Il2CppInterop.Runtime\Il2CppException.cs:line 36
        //     at Unity.Entities.EntityQuery.get_IsCacheValid()
        //     at cheesasaurus.VRisingMods.SystemsDumper.CodeGeneration.EcsSystemCodeGenerator.GenerateEntityQueryExampleInitializationLines(NamedEntityQuery namedQuery)
        
        
        __query_1698666241_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Rukhanka.GPURuntimeAnimationData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
