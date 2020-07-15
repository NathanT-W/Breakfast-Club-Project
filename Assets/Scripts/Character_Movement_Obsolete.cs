using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour {

    public float speed = 3.0f;
    public float gravity = 10.0f;

    public bool pickedup;

    public Texture2D crosshairImage;

    private Vector3 moveDirection = Vector3.zero;


	// Use this for initialization
	void Start () {

        // Disable mouse cursor

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnGUI() {

        // Draw crosshair on the hud

        float xMin = (Screen.width / 2) - (crosshairImage.width / 2);
        float yMin = (Screen.height / 2) - (crosshairImage.height / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width, crosshairImage.height), crosshairImage);
    }
	// Update is called once per frame
	void Update () {
        CharacterController characterController = GetComponent<CharacterController>();

        if (characterController.isGrounded)
        {

            // If character is on the ground, move character in specified direction

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            moveDirection.y = 0;
        }

        // Pull character to the floor, simulating gravity

        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
	}
}
