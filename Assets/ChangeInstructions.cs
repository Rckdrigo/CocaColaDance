using UnityEngine;
using System.Collections;

public class ChangeInstructions : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
			GameStateManager.Instance.GoToSelector();
	}
}
