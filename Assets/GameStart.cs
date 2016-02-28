using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {
	public string sceneName;

	public void loadGame (){
		Application.LoadLevel(sceneName);
	}

}
