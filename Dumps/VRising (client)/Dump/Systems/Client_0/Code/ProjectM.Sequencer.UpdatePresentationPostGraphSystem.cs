using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.SequencerPresentationGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.PresentationGraphSystem_Update))]
public class UpdatePresentationPostGraphSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1412667600_0;
    EntityQuery __query_1412667600_1;
    EntityQuery __query_1412667600_2;
    EntityQuery __query_1412667600_3;
    EntityQuery __query_1412667600_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        // Error processing _Query
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
        
        
        __query_1412667600_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Sequencer.SequenceInstance>(),
                ComponentType.ReadOnly<Stunlock.Sequencer.SequenceAsset>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.EventStateElement>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.BlackboardElement>(),
            },
        });
        
        __query_1412667600_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridCameraData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1412667600_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1412667600_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1412667600_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraTarget>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
