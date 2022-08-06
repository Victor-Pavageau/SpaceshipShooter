using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenu : MonoBehaviour {
    public string LevelName;

    public void SetLevelNameToMars() {
        LevelName = "MarsLevel";
    }

    public void SetLevelNameToMoon() {
        LevelName = "MoonLevel";
    }

    public void SaveLevel() {
        SaveSystem.SaveLevel(this);
    }
}
