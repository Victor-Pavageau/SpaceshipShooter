using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiderSpaceshipMovement : MonoBehaviour {
    private CharacterController characterControllerComponent;
    private int speed = 4;
    private Vector3 moveVector;

    void Start() {
        characterControllerComponent = GetComponent<CharacterController>();
    }

    void Update() {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        characterControllerComponent.Move(move * Time.deltaTime * speed);
        moveVector = move;
    }

    private void FixedUpdate() {
        if (moveVector != Vector3.zero) {
            transform.forward = moveVector;
        }
    }
}
