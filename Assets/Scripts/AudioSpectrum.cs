using UnityEngine;
using System.Collections;

public enum MusicalNote{
	Do1 = 64,
	Do2 = 128,
	Do3 = 256,
	Do4 = 512,
	Re1 = 74,
	Re2 = 146,
	Re3 = 294,
	Re4 = 588,
	Mi1 = 82,
	Mi2 = 164,
	Mi3 = 330,
	Mi4 = 660,
	Fa1 = 88,
	Fa2 = 174,
	Fa3 = 350,
	Fa4 = 698,	
	Sol1 = 98,
	Sol2 = 196,
	Sol3 = 392,
	Sol4 = 784,
	La1 = 110,
	La2 = 220,
	La3 = 440,
	La4 = 880,
	Si1 = 124,
	Si2 = 246,
	Si3 = 494,
	Si4 = 988, 	
}

public class AudioSpectrum : Singleton<AudioSpectrum>{
	
	[HideInInspector()]
	public float[] spectrum;

	void Start(){
		spectrum = new float[1024];
	}

	void FixedUpdate () {
		AudioListener.GetSpectrumData(spectrum,0,FFTWindow.Hanning);
	}
	
}
