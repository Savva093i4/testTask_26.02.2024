using System;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(UnityEngine.Camera))]
public class CameraMoveControl : MonoBehaviour
{
    [SerializeField] private float moovementTime;

    public void MoveCameraToPoint(Vector3 aimPoin)
    {
        aimPoin.z = transform.position.z;
        transform.DOMove(aimPoin, moovementTime);
    }

    public void ResetCameraPosition()
    {
        transform.position = new Vector3(0, 0, transform.position.z);
    }
}