using UnityEngine;
using System.Collections;

public class LoadGame : MonoBehaviour {
	public string sceneName;

	public void loadGame (){
		UiController.gameOver = false;
		Application.LoadLevel(sceneName);
		Score.score = 0;
	}
}