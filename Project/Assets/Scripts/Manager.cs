using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	
	private InputManager input;

	bool paused;

	void Awake()
	{
		input = GetComponent<InputManager>();

		Cursor.visible = false;
		paused = false;
	}

	private void Update()
	{
		if(input.pause)
		paused = !paused;

		if(paused)
		{
			Cursor.visible = true;
			Time.timeScale = 0;
		}

		else if(!paused)
		{
			Cursor.visible = false;
			Time.timeScale = 1;
		}
	}

	public void Pause()
	{
		Time.timeScale = 0;
	}

	public void Unpause()
	{
		Time.timeScale = 1;
	}
}