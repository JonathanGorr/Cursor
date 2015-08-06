using UnityEngine;
using System.Collections;
 
 public class CameraFollow : MonoBehaviour {

 	public float dampTime = 0.15f;
 	private Vector3 velocity = Vector3.zero;
 	private Rect screenRect;
 
 	void Start()
 	{
 		//create a new rectangle and set it to the window size
     	screenRect = new Rect(0,0, Screen.width, Screen.height);
 	}

     void Update () {

     	//if the mouse isn't within the window, easy out
 		if (!screenRect.Contains(Input.mousePosition))
     	return;
 		
 		//set the variable mouseScreen to mouseposition(screen)
        Vector3 mouseScreen = Input.mousePosition;

 		Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
 		mouseWorld.z = -1;

 		transform.position = mouseWorld;
     } 
 }

 public float dampTime = 0.15f;
     private Vector3 velocity = Vector3.zero;
     public Transform target;
 
     // Update is called once per frame
     void Update () 
     {
         if (target)
         {
             Vector3 point = camera.WorldToViewportPoint(target.position);
             Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
             Vector3 destination = transform.position + delta;
             transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
         }
     
     }
 }
