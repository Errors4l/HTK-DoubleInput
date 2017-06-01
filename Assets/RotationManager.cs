using UnityEngine;
using HoloToolkit.Unity;

public class RotationManager : Singleton<RotationManager>
{
    public GameObject TargetObject;

    public void RotateClockwise(float degrees)
    {
        if (TargetObject == null)
        {
            Debug.LogError("RotationManager has no TargetObject set!");
            return;
        }

        TargetObject.transform.Rotate(Vector3.up, degrees);
        Debug.LogFormat("TargetObject rotated {0} degrees.", degrees);
    }
}
