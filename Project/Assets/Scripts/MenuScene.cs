using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuScene : MonoBehaviour {

	private CanvasGroup fadeGroup;
	private float fadeinSpeed = 0.33f;

	public RectTransform menuContainer;

	public Transform levelPanel;
	public Transform optionPanel;

	public Vector3 actualMenuPosition;

	private void Start () {
		fadeGroup = FindObjectOfType<CanvasGroup> ();
		Cursor.lockState = CursorLockMode.None;

		Cursor.visible = true;

		fadeGroup.alpha = 1;

		//Add Events for the levels. 
		InitLevel ();
	}

	private void Update () {

		//fade in 
		fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeinSpeed;

		//Navegação do menu suave 
		menuContainer.anchoredPosition3D = Vector3.Lerp (menuContainer.anchoredPosition3D, actualMenuPosition, 0.1f);
	}
	//Mover a camera entre menus. 
	private void NavigateTo (int menuIndex) {
		switch (menuIndex) {
			//0 e default e o menu principal 
			default:
				case 0:
				actualMenuPosition = Vector3.zero;
			break;
			//1 - Option Menu
			case 1:
					actualMenuPosition = Vector3.right * 800;
				break;
				//2 - level  Menu
			case 2:
					actualMenuPosition = Vector3.left * 800;
				break;
			case 3:
					actualMenuPosition = Vector3.left * 1600;
				break;
		}
	}
	//Botões. 
	public void OnPlayClick () {
		NavigateTo (1);

	}

	public void OnOptionClick () {
		NavigateTo (2);
	}
	public void OnCreditsClick () {
		NavigateTo (3);
		Debug.Log ("Change to options ");
	}
	public void OnExitClicked () {
		Application.Quit ();
	}
	public void OnBackClick () {
		NavigateTo (0);

	}

	private void InitLevel () {
		if (levelPanel == null)
			Debug.Log ("Falta referência");
		int i = 0;
		foreach (Transform t in levelPanel) {
			int currentIndex = i;
			Button b = t.GetComponent<Button> ();
			i++;
		}
	}
}