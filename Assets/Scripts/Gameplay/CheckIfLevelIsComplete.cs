using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfLevelIsComplete : MonoBehaviour {
    public GameObject CanvasBackground;
    public GameObject VictoryMenu;
    public GameObject HealthBar;

    void Update() {
        if(gameObject.transform.Find("Ennemies").gameObject.transform.childCount == 0) {
            CanvasBackground.SetActive(true);
            VictoryMenu.SetActive(true);
            HealthBar.SetActive(false);
        }
    }
}
