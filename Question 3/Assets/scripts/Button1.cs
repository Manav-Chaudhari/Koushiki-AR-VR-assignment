using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Button1 : MonoBehaviour
{
    public float distanceToMove = 5.0f; // distance to move the camera
    public GameObject cubeObject; // the 3D cube to use as the button

    private Camera mainCamera; // reference to the main camera

    private void Start()
    {
        mainCamera = Camera.main; // get the main camera
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // check if the left mouse button is clicked
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition); // cast a ray from the mouse position
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == cubeObject) // check if the ray hits the cube object
            {
                Vector3 newPosition = mainCamera.transform.position + mainCamera.transform.forward * distanceToMove; // calculate the new camera position
                mainCamera.transform.position = newPosition; // move the camera to the new position
            }
        }
    }
}

