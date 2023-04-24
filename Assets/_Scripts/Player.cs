using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static Player Instance { get; private set; }

    // TODO: Add automatic movement direction !! Must adapt left/right player actions 

    [SerializeField] private float playerSpeed = 1f;
    [SerializeField] private Transform player;

    private void Start() {
        InputManager.Instance.OnLeftMovement += InputManager_OnLeftMovement;
        InputManager.Instance.OnRightMovement += InputManager_OnRightMovement;
    }

    private void Update() {

        Vector3 playerPosition = player.transform.position;

        playerPosition.z += playerSpeed * Time.deltaTime;
        player.transform.position = playerPosition;
    }

    private void InputManager_OnLeftMovement(object sender, System.EventArgs e) {
        Debug.Log("Player Left Movement");
    }
    private void InputManager_OnRightMovement(object sender, System.EventArgs e) {
        Debug.Log("Player Right Movement");

    }

}
