# Using [Systems] vs [Hooks] to modify behavior

## Challenges with inserting a system
For every system I add, I need to come up with a couple lists:
- Which existing systems does my system need to run before
- Which existing systems does my system need to run after

And then figure out which group to add it to.

This requires wide and deep knowledge of the existing systems.

If I was working with source code and the unity editor, this would be... let's not say trivial... but much easier than working with a bunch of black boxes. I do technically have the machine code, but it's too obscure.

## Analyzing a system
I have a couple small things in a glass box:
- The system's type name (e.g. "DropInventoryItemSystem")
  - very useful as a starting point, to find which systems might be worth looking at
- cached entity queries
  - for a managed system: available as a property on the instance. [EntityQueries](https://docs.unity3d.com/Packages/com.unity.entities@1.3/api/Unity.Entities.ComponentSystemBase.EntityQueries.html)
  - for an unmanaged system: unavailable AFAIK.
    - I was hoping there would be something in its [SystemState](https://docs.unity3d.com/Packages/com.unity.entities@1.3/api/Unity.Entities.SystemState.html) but no such luck.

The majority is a black box and analysis is done by diffing state.
- What did the relevant entity+components look like before OnUpdate?
- What did the relevant entity+components look like after OnUpdate?
- If I change the inputs (via mutating state before OnUpdate), how does the behavior change?

That state observation/control is where detours/events shine. And where system insertion does not.
- My system cannot be inserted *directly* before another system.
- My system cannot be inserted *directly* after another system.

(ISystems blocking my ability to analyze, is the reason I abandoned my modding attempts before)


## Theoretical alternative, using custom systems (no hooks)

In principle, the same could be achieved by replacing the target system with my own grouping, like this.

Before:
```
SystemA
SystemB
SystemC
```
After:
```
ExistingSystemA
  MyGroup
    MyPrefixSystem
      SystemB
    MyPostfixSystem
ExistingSystemC
```

### Problems with this approach
- MyGroup will need the same `[UpdateInGroup()]`, `[UpdateBefore()]` and `[UpdateAfter()]` attributes as SystemB
  - The generated interops for SystemB don't have these attributes
- Every other system that needed to update before/after SystemB now needs to target MyGroup instead
  - There is no way to do that AFAIK
- Moving SystemB to MyGroup. Is it even possible?
  - How do we remove it from its current update group? It can't have two parents in the update hierarchy.
    - It's a tree, not a DAG. (I think)
    - Do we have to remove it from the world before adding it to MyGroup?
      - Surely this would break all kinds of things that the world internally manages?
        - I suspect a system instance can't be added back to a world after being removed.

Event if this worked, it's much simpler to write a detour/event callback targeting SystemB.OnUpdate.


## Skipping an undesired system update

### via Events or custom Systems
- disable the system
  - managed system: set [ComponentSystemBase.Enabled](https://docs.unity3d.com/Packages/com.unity.entities@1.3/api/Unity.Entities.ComponentSystemBase.Enabled.html)
  - unmanaged system: set [SystemState.Enabled](https://docs.unity3d.com/Packages/com.unity.entities@1.3/api/Unity.Entities.SystemState.Enabled.html)
    - SystemState can be acquired via [World.Unmanaged.GetExistingSystemState](https://docs.unity3d.com/Packages/com.unity.entities@1.3/api/Unity.Entities.WorldUnmanaged.GetExistingSystemState.html)
- high risk of plugin conflict (e.g. PluginA enables a system, while PluginB expects that system to still be disabled)

### via Detours
- standard way to skip the method call
- stateless
- avoids some plugin conflicts
