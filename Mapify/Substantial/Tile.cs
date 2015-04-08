using UnityEngine;
using System.Collections;

namespace Substantial {
  [System.Serializable]
  public class Tile {
    public string Glyph;
    public GameObject Prefab;

    [Header("RandomPlacement")]
    public Vector3 MinPosition;
    public Vector3 MaxPosition;

    [Header("RandomRotation")]
    public Vector3 MinRotation;
    public Vector3 MaxRotation;

    public char Character {
      get { return Glyph[0]; }
    }

    public Vector3 LocalPosition {
      get {
        return new Vector3(
            Random.Range(MinPosition.x, MaxPosition.x),
            Random.Range(MinPosition.y, MaxPosition.y),
            Random.Range(MinPosition.z, MaxPosition.z)
            );
      }
    }

    public Quaternion Rotation {
      get {
        var euler = new Vector3(
            Random.Range(MinRotation.x, MaxRotation.x),
            Random.Range(MinRotation.y, MaxRotation.y),
            Random.Range(MinRotation.z, MaxRotation.z)
            );
        return Quaternion.Euler(euler);
      }
    }
  }
}
