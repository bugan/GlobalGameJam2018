using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class SplashCreen : MonoBehaviour {
	public UnityEvent TerminarCena;
	private CanvasGroup fadeGroup; 
	private float loadTime; 
	private float minLogoTime = 3.0f; 

	private void Start(){

		fadeGroup = FindObjectOfType<CanvasGroup>();

		fadeGroup.alpha = 1; 

		if(Time.time < minLogoTime)
			loadTime = minLogoTime; 
		else
			loadTime = Time.time;
	}

	private void Update()
	{
		
		//Fade in 
		if(Time.time < minLogoTime)
		{
			fadeGroup.alpha = 1 - Time.time;
		}

		//Fade Out
		if(Time.time > minLogoTime && loadTime != 0)
		{
			fadeGroup.alpha = Time.time - minLogoTime;
			if(fadeGroup.alpha >= 1)
			{
				TerminarCena.Invoke();
			}
		}			


	}
}
