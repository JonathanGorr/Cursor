using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	[HideInInspector]
	public bool pause;

	void Update()
	{
		pause = Input.GetKeyDown(KeyCode.Escape);
	}
}
