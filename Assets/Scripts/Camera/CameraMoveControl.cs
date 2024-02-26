using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(UnityEngine.Camera))]
public class CameraMoveControl : MonoBehaviour
{
    [SerializeField] private float moovementSpeed;

    public void MoveCameraToPoint(Vector3 aimPoin)
    {
        aimPoin.z = -200;
        transform.DOMove(aimPoin, 1);
    }
}
