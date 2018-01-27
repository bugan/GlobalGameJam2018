using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour {

	public Transform posicao;

	private void OnTriggerEnter (Collider other) {
		if (other.tag == "Cubo") {
			this._fixar (other.transform);
		}
	}

	private void _fixar (Transform cubo) {
		Pegavel  pegavel = cubo.GetComponent<Pegavel>();
		pegavel.SendMessageUpwards("soltarCaixa");
		cubo.transform.parent = this.posicao;
		cubo.localPosition = Vector3.zero;
		cubo.localRotation = this.posicao.localRotation;
		pegavel.soltar();
		
	}
}