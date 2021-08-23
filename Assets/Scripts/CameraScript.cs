using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject prefab;
    private bool mouseClicked = false;
    private float mouseDown;
    private float mouseReleased;
    private Vector3 mousePosition;
    private Camera cam;

    //private Rigidbody ball;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {         
        if (Input.GetMouseButtonDown(0))
        {
            mouseDown = Time.time;

            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 4;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePos);
            mousePosition.z = -4;

            Debug.Log(new Vector2(mousePosition.x, mousePosition.y));
            mouseClicked = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            mouseReleased = Time.time;
        }
  
    }

    private void FixedUpdate()
    {
        if (mouseReleased > mouseDown && mouseClicked) 
        {
            float force = (mouseReleased - mouseDown) * 50;
            Debug.Log(force);
            GameObject ballGO = (GameObject) Instantiate(prefab, mousePosition, Quaternion.identity);

            Rigidbody ballRb = ballGO.GetComponent<Rigidbody>();
            ballRb.AddForce(Vector3.forward * force, ForceMode.VelocityChange);
                    
            mouseClicked = false;
        }  
    }
}
