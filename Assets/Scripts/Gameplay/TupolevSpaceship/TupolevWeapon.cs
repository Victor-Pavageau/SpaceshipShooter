using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TupolevWeapon : MonoBehaviour {
    [SerializeField] private Transform firePoint1;
    [SerializeField] private Transform firePoint2;
    [SerializeField] private GameObject bulletPrefab;
    private bool gameIsPaused;
    private float speedShooting = 0.9f;
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
        Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
        Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
    }
}
