using UnityEngine;
using System.Collections;
using Substantial;

public class Mapify {
  public static void Generate(string map, Transform container, TileRepository tileRepository, float tileOffset, MapifyLayout layout) {
    var localPositionCalculator = new LocalPositionCalculator(tileOffset, layout);
    var iterator = new MapIterator(map.SplitOnNewline(), localPositionCalculator);
    new LevelPopulator(iterator, tileRepository, container).Populate();
  }
}
