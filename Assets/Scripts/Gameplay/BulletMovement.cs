using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {
    private int bulletSpeed = 10;
    [SerializeField] private Rigidbody bulletRigidbody;

    void Start() {
        bulletRigidbody.velocity = transform.up * bulletSpeed;
    }


    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name.Contains("Ennemy")) {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }
}
