using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiderWeapon : MonoBehaviour {
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bulletPrefab;
    private bool gameIsPaused;
    private float speedShooting = 0.4f;
    private float shootingDelay;

    private void Start() {
        gameIsPaused = false;
        shootingDelay = speedShooting;
    }

    private void Update() {
        if (!gameIsPaused) {
            if (shootingDelay > 0) {
                shootingDelay -= Time.deltaTime;
            }
            else {
                Shoot();
                shootingDelay = speedShooting;
            }
        }
    }

    public void ResumeGame() {
        gameIsPaused = false;
    }

    public void PauseGame() {
        gameIsPaused = true;
    }

    private void Shoot() {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
