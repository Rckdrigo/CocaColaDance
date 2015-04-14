using UnityEngine;
using System.Collections;

public class AdaptModel : MonoBehaviour {

	public Vector3 rotate;
	public Vector3 scale;

	// Update is called once per frame
	void Update () {
		transform.Rotate(rotate);
		
		transform.localScale = scale;
	}
}
