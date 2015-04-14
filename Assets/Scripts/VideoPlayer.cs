using UnityEngine;
using System.Collections;

public class VideoPlayer : MonoBehaviour {

	public MovieTexture tex;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.mainTexture = tex;
		tex.loop = true;
		tex.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
