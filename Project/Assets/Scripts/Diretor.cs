using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Diretor : MonoBehaviour {
	public UnityEvent AoTerminar;

	public void terminarCena(){
		this.AoTerminar.Invoke();
	}
}
