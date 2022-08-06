using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpaceshipData {
    public string SpaceshipName;

    public SpaceshipData(SpaceshipMenu spaceshipMenu) {
        SpaceshipName = spaceshipMenu.SpaceshipName;
    }
}
