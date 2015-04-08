using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Substantial {
  public class TileRepository : MonoBehaviour {
    public Tile[] Tiles;
    private Dictionary<char, Tile> lookupTable = new Dictionary<char, Tile>();

    private void Awake() {
      foreach (var tile in Tiles) {
        lookupTable[tile.Character] = tile;
      }
    }

    public bool HasKey(char character) {
      return lookupTable.ContainsKey(character);
    }

    public Tile Find(char character) {
      return lookupTable[character];
    }
  }
}
