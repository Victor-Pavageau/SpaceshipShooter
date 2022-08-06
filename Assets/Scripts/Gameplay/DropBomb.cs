using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBomb : MonoBehaviour {
    private float randomCouldown;
    private bool gameIsPaused;
    [SerializeField] private Transform bombSpawnPoint;
    [SerializeField] private GameObject bombPrefab;

    void Start() {
        randomCouldown = Random.Range(1, 8);
        gameIsPaused = false;
    }

    void Update() {
        if(!gameIsPaused) {
            if (randomCouldown > 0) {
                randomCouldown -= Time.deltaTime;
            }
            else {
                DropABomb();
                randomCouldown = Random.Range(1, 8);
            }

        }
    }

    public void ResumeGame() {
        gameIsPaused = false;
    }

    public void PauseGame() {
        gameIsPaused = true;
    }

    private void DropABomb() {
        Instantiate(bombPrefab, bombSpawnPoint.position, bombSpawnPoint.rotation);
    }
}
