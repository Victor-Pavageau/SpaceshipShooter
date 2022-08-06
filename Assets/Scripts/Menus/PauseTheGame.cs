using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTheGame : MonoBehaviour {
    public RaiderWeapon RaiderWeapon;
    public TupolevWeapon TupolevWeapon;
    public DropBomb DropBomb;
    public GameObject CanvasBackground;
    public GameObject PauseMenu;
    public GameObject HealthBar;
    public GameObject VictoryMenu;
    public GameObject DefeatMenu;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) && !VictoryMenu.activeSelf && !DefeatMenu.activeSelf) {
            RaiderWeapon.PauseGame();
            TupolevWeapon.PauseGame();
            DropBomb.PauseGame();

            CanvasBackground.SetActive(true);
            PauseMenu.SetActive(true);
            HealthBar.SetActive(false);
        }
    }
}
