using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<VideoPlayer>().clip = Resources.Load<VideoClip>("Videos/🔴 Best 360 VR VIDEO 4K");
       // GetComponent<VideoPlayer>().source = Resources.Load<VideoClip>("Videos/Sonic Animation - SONIC THE HEDGEHOG BATTLE 360° VR- SFM Animation (Sonic Animation)");
        GetComponent<VideoPlayer>().Prepare();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<VideoPlayer>().isPrepared&&! GetComponent<VideoPlayer>().isPlaying)
        {
            GetComponent<VideoPlayer>().Play();
        }
	}
}
