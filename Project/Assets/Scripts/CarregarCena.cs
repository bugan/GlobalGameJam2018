﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCena : MonoBehaviour {

	public void carregarCenaViaEvento(string cena){
		SceneManager.LoadScene(cena);
	}
}
