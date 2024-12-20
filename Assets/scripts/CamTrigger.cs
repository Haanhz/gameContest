using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    public Vector3 newCampos, newPlayerpos;
    CamController camControll;
    public Camera cam;

    private void Start() {
        camControll = cam.GetComponent<CamController>();

    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="Player"){
            camControll.minPos += newCampos;
            camControll.maxPos += newCampos;

            other.transform.position+=newPlayerpos;
        }
    }
}
