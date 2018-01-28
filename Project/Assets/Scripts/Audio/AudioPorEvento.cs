using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPorEvento : MonoBehaviour {
	public float chanceDeTocar;
	private AudioSource _audio;
	void Start () {
		this._audio = this.GetComponent<AudioSource>();
	}
	
	public void AlterarChance(float i){
		this.chanceDeTocar = i;
		Debug.Log(i);
	}
	public void tentarTocarAudio(){
		float random = Random.RandomRange(0f,1f);
		
		if(random < this.chanceDeTocar){
			this._audio.Play();
		}
	}
}
