using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararAudioPorTempo : MonoBehaviour {
	
	public int indexCena;
	public float tempoEsperado;
	private bool jaTocou;
	private float recorde;
	private float _cronometro;
	private AudioSource _audio;

	void Start () {
		this._audio = this.GetComponent<AudioSource>();
		this.recorde = PlayerPrefs.GetFloat("Cena"+this.indexCena);
		if(this.recorde == 0)
		{
			this.recorde = this.tempoEsperado;
		}
	}
	void Update () {
		this._cronometro += Time.deltaTime;

		if(this._cronometro > this.recorde && !this.jaTocou){
			this._audio.Play();
			this.jaTocou = true;
		}
	}
}
