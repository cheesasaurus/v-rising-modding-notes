# Creating symbolic links
Various plugin projects reference copied BepInEx folders such as `interop` and `core`.\
Use symbolic links if you don't want to copy files around.


## Windows: Command Prompt
_Run as administrator._

usage:
```
mklink /d "Link Directory" "Target Directory"
```

example:
```
mklink /d "A:\vrmod\projects\_plugins\BepInEx" "F:\Games\SteamLibrary\steamapps\common\VRisingDedicatedServer\BepInEx"
```

## Windows: Powershell
_Run as administrator._

usage:
```
New-Item -ItemType SymbolicLink -Path "Link Directory" -Value "Target Directory"
```

example:
```
New-Item -ItemType SymbolicLink -Path "A:\vrmod\projects\_plugins\BepInEx" -Value "F:\Games\SteamLibrary\steamapps\common\VRisingDedicatedServer\BepInEx"
```
