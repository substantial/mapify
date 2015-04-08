# mapify

# Synopsis

Make your levels in Unity3d out of ascii text files.

```
    xCxxc                 
1        m m  X   X   X  X
xxxxxxxxxxxxxxxxxxxxxxx  x
```


# Features

.txt files!

* They're small!
* They're fast!
* They're cross platform and can be edited in nearly anything, even VIM or Emacs!
* They can be stored and diffed in source control!
* [Making levels](https://raw.githubusercontent.com/substantial/mapify-example/master/app/Assets/Maps/test.txt) is like being in a roguelike (pew, pew, pew!)

But seriously, here's some real features:

* Includes a tile repository script for defining mappings between glyphs and 
  prefabs.
* Each tile prefab can spawn with a random positional or rotational offset.
  This is helpful for breaking up your grid visually (e.g., rocks, trees, enemies)
* You can store your text files in the resources folder and load them dynamically
  with Unity3d's AssetDatabase, or transfer them from over the web with WWW
* You can have multiple maps per level, so you can have one map for an enemies layer,
  another for the obstacles layer and a third for terrain. Or with a little work
  you could dynamically load in chunks of maps and destroy the ones that just
  fell out of sight.
* You can tell Mapify to use any tile size for tiles (e.g., 1x1, 4x4, 16x16, 32x32, etc.)
* You can tell Mapify to generate horizontal or vertical levels
* Automatically detects width and height of your level and centers it in the
  container you pass in

# Installation

Drop the Mapify folder in your Assets directory.

# Usage

1. Create a text map like this one: [test.txt](https://raw.githubusercontent.com/substantial/mapify-example/master/app/Assets/Maps/test.txt)
2. Add an empty gameObject to your scene and name it something memorable like 
   `GameInitializer`
3. Add a `TileRepository` script to your game scene and define some glyph mappings 
   like x -> WallPrefab, 1 -> PlayerPrefab, etc. 
   [Screenshot](https://raw.githubusercontent.com/substantial/mapify-example/master/screens/wired.png)
4. Create a script [like this](https://raw.githubusercontent.com/substantial/mapify-example/master/app/Assets/Scripts/GameInitializer.cs) that tells Mapify about your text map and tile repository

Run the scene. You're done.

![Screenshot](https://raw.githubusercontent.com/substantial/mapify-example/master/screens/screenshot.png)

# Example project

Check out https://github.com/substantial/mapify-example

# Tips and Tricks

You can use this tool however you want, but the author strongly recommends working
with larger prefab tile sizes than smaller.  For example, if your tile size is 
set to 32x32, each tile will be 1024 times less work to place than the same map with 
1x1 prefabs. This is good for Unity (as 10,000 gameobjects will ruin your FPS) and 
it's good for you because creating levels with 1x1 tiles (like we did in Dungeon 
Highway 1) can be... tedious.

# What it's not good at

* 3d. The map format is decidedly 2d. While your prefabs can of course
  have a 3rd dimension, they're going to lay out on a 2d grid and a flat 2d grid 
  sounds kind of boring for a first person shooter. Maybe it's fun, we don't know.
* It's designed to dynamically build levels, so it's not great if you rely on things
  previously stored in the scene like baked lighting or navmeshes. There's nothing 
  to stop you from running the Mapify script in the editor and saving the scene, 
  but updating your levels sounds like a pain.
* There's no way to define special properties for different tiles.

  For example, while X can spawn your ExitPrefab, you can't tell X that this X
  needs to know that the next level is called "SewerLevel".  You'll have to 
  figure out how to pass that information to ExitPrefab some other way like 
  have talk to a singleton or static data class on start (e.g., LevelSettings.NextLevel),
  or do something stupid like create multiple prefabs: X -> ExitToSewerPrefab, 
  and Y -> ExitToSpacePrefab.

  That's not to say that you couldn't hack in an initializer to the tile spawner
  that passes some custom info to every tile.  We did something similar in 
  Dungeon Highway for telling each object what the area's Theme is. It was very 
  particular to our game though, so we pulled it out of this plugin before release...

  Anyway, the code isn't that complicated. Just look at it.

# Contact

If you've got any pull requests, comments, questions, or just want to send over
Starbucks giftcards, feel free to contact me! (Also, you can hire my employer, 
Substantial, to make your game.)

mike@substantial.com

