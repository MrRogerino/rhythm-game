using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChangeScript : MonoBehaviour {

    public Material skyboxMat;


	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.CompareTag("NoteBar")){
            RenderSettings.skybox = skyboxMat;
        }
    }
}
