using UnityEngine;
using System;
using System.Collections;

namespace Substantial {
  public class LevelPopulator {
    private MapIterator mapIterator;
    private TileRepository tileRepository;
    private Transform container;

    public LevelPopulator(MapIterator mapIterator, TileRepository tileRepository, Transform container) {
      this.mapIterator = mapIterator;
      this.tileRepository = tileRepository;
      this.container = container;
    }

    public void Populate() {
      mapIterator.Iterate((character, localPosition) => {
          if (tileRepository.HasKey(character)) {
            var tile = tileRepository.Find(character);
            var worldPosition = container.TransformPoint(localPosition);
            TileSpawner.Create(tile, worldPosition, container);
          }
      });
    }
  }
}
