using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    [SerializeField] GameObject prefab;

    [SerializeField] int amountToSpawn = 1;

    [SerializeField] private float range = 1;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < amountToSpawn; i++)
        {
            //get a random position based on the spawners location
            Vector3 pos = new Vector3(
                transform.position.x + Random.Range(-range, range), 
                transform.position.y + 3f, 
                transform.position.z + Random.Range(-range, range));
            //spawn the object at that position
            Instantiate(prefab, pos, transform.rotation);
        }

    }

}