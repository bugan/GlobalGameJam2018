using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CarregarMuitasCenas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SceneManager.LoadSceneAsync("StageTeste1", LoadSceneMode.Additive);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
