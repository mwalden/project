using UnityEngine;
using System.Collections;
using AC;

public class ChangeScene : MonoBehaviour {
	public Cutscene myCutScene;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			myCutScene.Interact ();
		}
	}

	void OnMouseDown(){
		myCutScene.Interact ();
	}
}
