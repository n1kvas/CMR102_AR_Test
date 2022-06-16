using UnityEngine;
using UnityEngine.Serialization;
using Vuforia;

public class TargetHandler : MonoBehaviour
{
    [SerializeField] private GameObject scanWarning;
    private ObserverBehaviour _modelTargetBehaviour;
    
    void Start()
    { 
        _modelTargetBehaviour = gameObject.GetComponent<ObserverBehaviour>(); 
        _modelTargetBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
    }
    
    void OnTargetStatusChanged(ObserverBehaviour observerBehavior, TargetStatus status)
    {
        if (status.Status == Status.TRACKED && status.StatusInfo == StatusInfo.NORMAL)  
        {
            scanWarning.SetActive(false);
        }
        else
        {
            scanWarning.SetActive(true);
        }
        
    }
    
}
