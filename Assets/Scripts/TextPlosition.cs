using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPlosition : MonoBehaviour
{
    [SerializeField] private GameObject parent;
   
    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(0, 0.5f, 0);
        transform.LookAt(Camera.main.transform);
        // transform.localEulerAngles = new Vector3(180, 0, 0);
    }
}
