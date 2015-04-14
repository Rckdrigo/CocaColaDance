using UnityEngine;
using System.Collections;

public class BeatDefinition : MonoBehaviour {

	public float beatFrequency;

	public Transform[] references;

	void Start () {	
		transform.localScale = new Vector3(0,0,0);
		StartCoroutine(Beat());
	}


	IEnumerator Beat(){
		transform.position = references[Random.Range(0,references.Length)].position;
		transform.localScale = new Vector3(1,1,1);
		yield return new WaitForSeconds(beatFrequency);
		
		
		transform.localScale = new Vector3(0,0,0);
		yield return new WaitForSeconds(beatFrequency);
		StartCoroutine(Beat());

	}
}
