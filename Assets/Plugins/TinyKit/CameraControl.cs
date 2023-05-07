using UnityEngine;

public enum CamType
{
    Follow,
    LookAt
}

[DisallowMultipleComponent]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("TinyKit/Camera Control")]
public class CameraControl : MonoBehaviour
{
    public bool Enable;
    public GameObject target;
    public CamType cameraType = CamType.Follow;

    void Start()
    {
        if (target == null)
        {
            target = GameObject.FindWithTag("Player");
            if (target != null)
            {
                Debug.LogWarning("Target Replaced!");
            }
        }
    }

    void Update()
    {
        if (Enable)
        {
            switch (cameraType) {
                case CamType.Follow:
                    // Mathf.Lerp
                    break;
                case CamType.LookAt:
                    transform.LookAt(target.transform);
                    break;
            }
        }
    }
}
