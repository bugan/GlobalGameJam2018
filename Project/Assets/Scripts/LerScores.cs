using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerScores : MonoBehaviour {
	public GameObject prefab;
	public int numCenas;
	
	void Start () {
		for(int i=0 ; i<this.numCenas ; i++){
			string nome = "Fase "+(i+1);
			float recorde = PlayerPrefs.GetFloat("Cena"+i);
			GameObject obj = Instantiate(prefab);
			obj.GetComponent<ConfigurarScore>().Init(nome, recorde);
			obj.transform.parent = this.transform;
		}
	}
	
	void Update () {
		
	}
}
