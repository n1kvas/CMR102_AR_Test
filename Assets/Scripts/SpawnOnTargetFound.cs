using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Vuforia;
public class SpawnOnTargetFound : MonoBehaviour
{
    [SerializeField] private ObserverBehaviour _modelTargetBehaviour;

    [SerializeField] private GameObject _parent;
    
    [SerializeField] GameObject prefab;

    [SerializeField] int amountToSpawn = 1;

    [SerializeField] private float range = 1;
    void Start()
    { 
        // _modelTargetBehaviour = gameObject.GetComponent<ObserverBehaviour>(); 
        _modelTargetBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
    }
    
    void OnTargetStatusChanged(ObserverBehaviour observerBehavior, TargetStatus status)
    {
        if (status.Status == Status.TRACKED && status.StatusInfo == StatusInfo.NORMAL)  
        {
            for(int i = 0; i < amountToSpawn; i++)
            {
                //get a random position based on the spawners location
                Vector3 pos = new Vector3(
                    _parent.transform.position.x + Random.Range(-range, range), 
                    _parent.transform.position.y + .03f, 
                    _parent.transform.position.z + Random.Range(-range, range));
                //spawn the object at that position
                Instantiate(prefab, pos, transform.rotation);
            }

        }
        else
        {
        }
        
    }
}
