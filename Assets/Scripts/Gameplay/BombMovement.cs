using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMovement : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name.Contains("Border")) {
            Destroy(gameObject);
        }
    }
}
