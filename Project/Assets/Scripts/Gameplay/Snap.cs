using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour {

	public Transform posicao;

	private GameObject _ocupante;

	private void OnTriggerEnter (Collider other) {
		if (other.tag == "Cubo" && this._ocupante == null) {
			this._fixar (other.transform);
		}
	}

	private void OnTriggerExit (Collider other) {
		if (other.gameObject == this._ocupante) {
			this._ocupante = null;
		}
	}

	private void _fixar (Transform cubo) {
		Pegavel pegavel = cubo.GetComponent<Pegavel> ();
		if (pegavel.ligada)
			pegavel.SendMessageUpwards ("soltarCaixa");

			
		cubo.transform.parent = this.posicao;
		cubo.localPosition = Vector3.zero;
		cubo.localRotation = this.posicao.localRotation;
		cubo.GetComponent<Rigidbody> ().Sleep ();
		pegavel.soltar ();
		this._ocupante = cubo.gameObject;

	}
}