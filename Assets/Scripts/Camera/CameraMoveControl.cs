using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Events;
using Player.ActionHandlers;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.Camera))]
public class CameraMoveControl : MonoBehaviour
{
    [SerializeField] private float moovementSpeed;
    private CinemachineVirtualCamera cinemachineVirtualCamera;

    public Transform Aim;

    private void Awake()
    {
        cinemachineVirtualCamera = GetComponentInChildren<CinemachineVirtualCamera>();
    }

    private void Start()
    {
       // MoveCameraToPoint(Aim);
    }

    public void MoveCameraToPoint(Transform aimPoin)
    {
        cinemachineVirtualCamera.m_Follow = aimPoin;
    }
}
