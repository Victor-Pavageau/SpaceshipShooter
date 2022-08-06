using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelData {
    public string LevelName;

    public LevelData(LevelMenu levelMenu) {
        LevelName = levelMenu.LevelName;
    }
}
