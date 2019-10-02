using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotation : MonoBehaviour {

    private void Update()
    {
        //rotate around local y axis 60 degree per second
        transform.Rotate(Vector3.down * Time.deltaTime * 60 );
    }
}
