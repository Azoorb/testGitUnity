using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    /*
    J'vais essayer de m'adapter à ton style de code ou de game design
    Parce que sinon on risque de faire des truc un peu bordéliques
    */

    private Rigidbody rb;

    private void Start() => rb = GetComponent<Rigidbody>();

    void Update()
    {
        transform.Rotate(new Vector3(7.5f, 15f, 7.5f) * Time.deltaTime);
    }
}
