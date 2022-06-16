using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARManager : MonoBehaviour
{
    [SerializeField] private GameObject _scanWarning;
    [SerializeField] private ObserverBehaviour modelTargetBehaviour;

    void Start()
  {
      // VuforiaBehaviour.Instance.DevicePoseBehaviour.OnTargetStatusChanged += OnDevicePoseStatusChanged; 
      
      modelTargetBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;

  }

    void OnTargetStatusChanged(ObserverBehaviour observerbehavour, TargetStatus status)
    {
        // if (status.Status == Status.TRACKED && status.StatusInfo == StatusInfo.NORMAL)
        if (status.Status == Status.TRACKED)
    
        {
            _scanWarning.SetActive(false);
        }
        else
        {
            _scanWarning.SetActive(true);
        }
        
    }
    
  //   void OnDevicePoseStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
  // {
  //     Debug.Log("OnDevicePoseStatusChanged(" + targetStatus.Status + ",=========" + targetStatus.StatusInfo + ")");
  // }
  
}
