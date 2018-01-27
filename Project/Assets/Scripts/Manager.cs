using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	public static Manager Instance { set ; get; }

	private  void Awake()
	{
		DontDestroyOnLoad(gameObject);
		Instance = this;
	}

	public int currentLevel = 0;  //Usado quanto troca do menu para o jogo.
	public int menuFocus = 0; // Usado quando você sair do jogo para o menu. 
}
