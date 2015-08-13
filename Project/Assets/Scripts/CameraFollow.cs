using UnityEngine;
using System.Collections;
 
 public class CameraFollow : MonoBehaviour {

 	public float dampTime = 0.15f;
 	private Vector3 velocity = Vector3.zero;

 	private Rect screenRect;

    private Ray ray;
    private Vector3 newPos;
 
 	void Start()
 	{
 		//create a new rectangle and set it to the window size
     	screenRect = new Rect(0,0, Screen.width, Screen.height);
 	}

     void FixedUpdate () {

        //Only work when mouse is in the window
        if (!screenRect.Contains(Input.mousePosition))
        return;

        ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        newPos = ray.GetPoint(15);
        newPos.z = -1;
        //transform.position = newPos;
        transform.position = Vector3.SmoothDamp(transform.position, newPos, ref velocity, dampTime);

     }
 }
