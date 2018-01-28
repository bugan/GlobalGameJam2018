using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour {

	public Text textoTempo;
	private float _tempo;
	void Start () {
		this._tempo = 0;
	}
	
	void Update () {
		this._tempo+= Time.deltaTime;
		this.textoTempo.text = (Mathf.FloorToInt(this._tempo/60)).ToString("N0") + ":" + (this._tempo%60).ToString("N0");
	}

	public void SalvarProgresso(int cena){
		float recordeAtual = PlayerPrefs.GetFloat("Cena"+cena);
		if(this._tempo < recordeAtual)
			PlayerPrefs.SetFloat("Cena"+cena, this._tempo);
	}
}
