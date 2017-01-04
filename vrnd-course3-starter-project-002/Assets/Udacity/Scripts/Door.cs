using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	bool unlocked = false;
	public AudioSource doorSource;
	public AudioClip[] soundFiles;
	bool allowedToOpen = false;

    void Update() {
		if (unlocked && (transform.position.y < 22) && allowedToOpen) {
			transform.Translate (0, Time.deltaTime / 4, 0, Space.World);
			doorSource.clip = soundFiles [1];
			doorSource.Play ();
		} 
		else if(!unlocked){
			doorSource.clip = soundFiles [0];
			doorSource.Play ();
		}	
    }

    public void Unlock()
    {
		unlocked = true;
    }

	// allows users to open door when interacting with it as they have collected the key.
	public void AllowedToOpen(){
		if (unlocked) {
			allowedToOpen = true;
		}
	}
}
