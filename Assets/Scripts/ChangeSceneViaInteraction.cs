using UnityEngine;
using System.Collections;
using AC;

public class ChangeSceneViaInteraction : MonoBehaviour {
	public Interaction interaction;
	public float seconds;
	private bool loading;
	void Update(){
		seconds -= Time.deltaTime;
		if (seconds < 0 && !loading) {
			loading = true;	
			interaction.Interact ();
		}
	}

}
