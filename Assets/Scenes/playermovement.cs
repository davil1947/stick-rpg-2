using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * speed * Time.deltaTime;

       
         // Move the character
    transform.position += new Vector3(1, 0, 0) * Time.deltaTime;

    // Log the character's position
    Debug.Log("Character position: " + transform.position);
    }
}
