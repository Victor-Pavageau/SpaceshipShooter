using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {
    [SerializeField] private GameObject spacheship;
    public int life;
    public HealthBar HealthBar;
    private float damageCooldown;
    public GameObject CanvasBackground;
    public GameObject DefeatMenu;
    public GameObject HealthBarGameObject;

    private void Start() {
        damageCooldown = 0.1f;
        if (spacheship.gameObject.name == "RaiderSpaceship") {
            life = 2;
        }
        else if (spacheship.gameObject.name == "TupolevSpaceship") {
            life = 3;
        }
        else {
            Application.Quit();
        }
        HealthBar.SetMaxHealth(life);
    }

    private void Update() {
        if(damageCooldown >= 0) {
            damageCooldown -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name.Contains("Bomb")) {
            Destroy(other.gameObject);
            if (damageCooldown < 0) {
                TakeDamage();
                damageCooldown = 0.1f;
            }
        }
    }

    private void TakeDamage() {
        life--;
        HealthBar.SetHealth(life);
        CheckDeath();
    }

    private void CheckDeath() {
        if (life <= 0) {
            Destroy(gameObject);
            CanvasBackground.SetActive(true);
            DefeatMenu.SetActive(true);
            HealthBarGameObject.SetActive(false);
        }
    }
}
