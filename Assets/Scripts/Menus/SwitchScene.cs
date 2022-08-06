using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {
    public GameObject CanvasBackground;
    public GameObject PauseMenu;
    public void GoToMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    public void ResumeGame() {
        CanvasBackground.SetActive(false);
        PauseMenu.SetActive(false);
    }
}
