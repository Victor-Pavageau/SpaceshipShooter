using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceshipMenu : MonoBehaviour {
    public string SpaceshipName;

    public void SetSpaceshipNameToRaider() {
        SpaceshipName = "Raider";
    }

    public void SetSpaceshipNameToTupolev() {
        SpaceshipName = "Tupolev";
    }

    public void SaveSpaceship() {
        SaveSystem.SaveSpaceship(this);
    }

    public void PlayGame() {
        SceneManager.LoadScene("LevelScene");
    }
}
