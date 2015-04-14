using UnityEngine;
using System.Collections;

public class MusicalNoteSpectrum : MonoBehaviour {

	public MusicalNote note;

	int index;
	[HideInInspector()]
	public float power;

	void Start(){
		index = Mathf.FloorToInt((float)note / 21.0f);
	}

	void FixedUpdate () {
		power = AudioSpectrum.Instance.spectrum[index-2] + AudioSpectrum.Instance.spectrum[index-1] + AudioSpectrum.Instance.spectrum[index] + AudioSpectrum.Instance.spectrum[index+1] + AudioSpectrum.Instance.spectrum[index+2];
		transform.localScale = new Vector3(1,power*15,1);
	}
}
