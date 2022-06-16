using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHanldler : MonoBehaviour
{
    [SerializeField] private GameObject theCube;
    [SerializeField] private GameObject arCamera;
    [SerializeField] private float speedX = 1f;
    [SerializeField] private float speedY = 1f;
    [SerializeField] private float speedZ = 1f;

    // Start is called before the first frame update
    void Start()
    {
        theCube.transform.position= arCamera.transform.position;
        theCube.transform.position = new Vector3(theCube.transform.position.x, theCube.transform.position.y, theCube.transform.position.z + 5f);
    }

    // Update is called once per frame
    void Update()
    {
        theCube.transform.position = new Vector3(arCamera.transform.position.x, arCamera.transform.position.y, arCamera.transform.position.z + 5f);

        theCube.transform.forward = new Vector3(arCamera.transform.forward.x * 2f, arCamera.transform.forward.y * 2F, arCamera.transform.forward.z * 2f);

        if (speedY < 1 && speedY > -1)
        {
            theCube.transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime);
        }
        else if (speedX < 1 && speedX > -1)
        {
            theCube.transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime);
        }
        else if (speedZ < 1 && speedZ > -1)
        {
            theCube.transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime);
        }
        else
        {
            speedY = 0;
            speedX = 0;
            speedZ = 0;
            theCube.transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime);
        }
    }
}
