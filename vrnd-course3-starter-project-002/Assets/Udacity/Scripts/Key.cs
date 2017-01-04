using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public GameObject keyPoof;
	public Door door;
	bool keyCollected = false;

	void Update()
	{
		transform.Translate(0, (Mathf.Sin(5*Time.time) / 30), 0);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab, unlock the door and destroy key
		Instantiate (keyPoof, transform.position, Quaternion.Euler(270, 0, 0));
		Destroy (gameObject);
		door.Unlock ();
		keyCollected = true;
    }

	public bool isKeyCollected(){
		return keyCollected;
	}
}
