using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaoDestruirAoCarregar : MonoBehaviour {
	void Start () {
		GameObject.DontDestroyOnLoad(this.gameObject);	
	}
}
