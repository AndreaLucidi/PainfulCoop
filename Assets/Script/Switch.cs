using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Switch : MonoBehaviour {
    public GameObject Block;
	// Use this for initialization
	void Start () {
        AudioListener.volume = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void NoAudio()
    {
        AudioListener.volume = 0f;
        Block.gameObject.SetActive(false);
    }
    public void NoVideo()
    {
        AudioListener.volume = 1f;
        Block.gameObject.SetActive(true);
    }
}
