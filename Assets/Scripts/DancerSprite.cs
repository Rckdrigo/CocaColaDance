using UnityEngine;
using System.Collections;

public class DancerSprite : MonoBehaviour {

	[HideInInspector()]
	public Transform reference = null;
	[HideInInspector()]
	public Sprite sprite;

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x,transform.position.y,reference.position.z);
		GetComponent<SpriteRenderer>().sprite = sprite;
	}
}
