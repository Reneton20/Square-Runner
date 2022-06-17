using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject  CloseCamera;
    public GameObject overheadCamera;

  

 /*   public void ShowFirstpersonView()
    {
        CloseCamera.enabled = true;
        overheadCamera.enabled = false;
    }

    public void ShowOverheadView()
    {
        CloseCamera.enabled = false;
        overheadCamera.enabled = true;
    }*/





    // Use this for initialization
    void Start () {

        //cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
