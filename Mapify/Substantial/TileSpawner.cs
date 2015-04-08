using UnityEngine;
using System;
using System.Collections;

namespace Substantial {
  public class TileSpawner {
    public static GameObject Create(Tile tile, Vector3 position, Transform parent) {
      var instance = GameObject.Instantiate(tile.Prefab, position, tile.Rotation) as GameObject;
      instance.transform.parent = parent;
      return instance;
    }
  }
}
