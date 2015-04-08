using UnityEngine;
using System;
using System.Collections;

namespace Substantial {
  public class MapIterator {
    private string[] map;
    private LocalPositionCalculator localPositionCalculator;

    public MapIterator(string[] map, LocalPositionCalculator localPositionCalculator) {
      this.map = map;
      this.localPositionCalculator = localPositionCalculator;
    }

    public void Iterate(Action<char, Vector3> callback) {
      for (var y = 0; y < map.Length; y++) {
        var line = map[y];
        for (var x = 0; x < line.Length; x++) {
          var character = line[x];
          var localPosition = localPositionCalculator.Calculate(x, y, map.Length, line.Length);
          callback(character, localPosition);
        }
      }
    }
  }
}
