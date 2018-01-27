using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletarLevel : MonoBehaviour {

	public void salvarLevel(int index){
		PlayerPrefs.SetInt("ultimoLevel", index);
	}
}
