using UnityEngine;
using System.Collections;

public class SphereGenerator : MonoBehaviour {

	[Range(0.1f,1f)]
	public float frecuency = 0.5f;
	public Transform[] nodes;

	void Start(){
		GameStateManager.Instance.MusicFinished += StopGenerating;
	}

	public IEnumerator GenerateSphere () {
		GameObject temp = ObjectPool.instance.GetGameObjectOfType("esferablanca",true) as GameObject;
		temp.transform.position = nodes[Random.Range(0,nodes.Length)].position;
		yield return new WaitForSeconds(frecuency);
		StartCoroutine(GenerateSphere());

	}

	void StopGenerating(){
		StopAllCoroutines();
	}

}
