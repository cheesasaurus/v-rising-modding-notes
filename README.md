# V Rising Modding
This repo will contain notes about modding V Rising.

## Hosting a dedicated server locally

In steam library, use the filter to show **Tools** in addition to Games.
There is a tool called "V Rising Dedidcated Server" - this is what's used to run a proper server.

This video is slightly outdated but its a good starting point.
https://www.youtube.com/watch?v=4qeEyTVV-qU

## BepInEx

Bepis Injector Extensible (BepInEx) is the magic that makes it all possible.

"BepInEx is a plugin / modding framework for Unity Mono, IL2CPP and .NET framework games (XNA, FNA, MonoGame, etc.)"

There's a preconfigured pack for V Rising: https://v-rising.thunderstore.io/package/BepInEx/BepInExPack_V_Rising/

Follow the installation instructions at the link.

After installation, you will need to run the game once and bepinex will generate a bunch of stuff.

## General mod installation

Installing a mod is as simple as copying a DLL file into the `./BepInEx/Plugins/` directory of your server.

## Bloodstone

Bloodstone provides some hot-reloading capabilities for your mods so you don't have to restart the server every time you want to test a change.

It also provides some convenient things through its `VWorld` helper. I've found myself using `VWorld.Server.EntityManager` a lot.

https://v-rising.thunderstore.io/package/deca/Bloodstone/

Follow the installation instructions at the link.

To hot reload mods you will put them in `./BepInEx/BloodstonePlugins/` instead of the usual Plugins folder.
Hot reloading is done via in-game chat. Admins can type `!reload` into the chat to trigger a reload.

## VCF
Vampire Command Framework (VCF) is a framework for creating chat commands.

What's a chat command? Its like a console command, except using the in-game chat instead of a console.
If you've played on a duel server and given yourself a blood potion by typing `.bp` - that is a chat command.

https://v-rising.thunderstore.io/package/deca/VampireCommandFramework/

Follow the installation instructions at the link.

## .NET SDK

You will need .NET SDK version 6.0 to create your own mods.

https://dotnet.microsoft.com/en-us/download/dotnet/6.0

At the time of writing, version 8 was recently released. Do not use that. V Rising uses version 6. Its ok if you have something newer already - you will be able to specify the TargetFramework for your project. But you still need to install SDK version 6.

## Creating your own mod

There's a nice project template for V Rising Mods.
https://github.com/decaprime/VRising.ModTemplate

The README explains how to install and use the project template. Note that you have to be in in the `templates` dir to do the installation step.

The template creates something similar to what you would get from following the [bepinex tutorial](https://docs.bepinex.dev/articles/dev_guide/plugin_tutorial/2_plugin_start.html), with some additional stuff:
- Bloodstone and VCF already set up
- nuget.config
- an example VCF command (commented out) in Plugin.cs

If can't build your project due to unresolved package references, you may need to modify nuget.config (I had to). Most of the dependencies are available on [nuget.org](https://www.nuget.org/packages), so add it as a source.

e.g.
```
<configuration>
  <packageSources>
    <add key="BepInEx" value="https://nuget.bepinex.dev/v3/index.json" />
    <add key="Samboy Feed" value="https://nuget.samboy.dev/v3/index.json" />

    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
  </packageSources>
</configuration>
```





