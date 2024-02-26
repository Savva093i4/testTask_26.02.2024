using UnityEngine;
using Utils.Singleton;

namespace Camera
{
    public class CameraHolder : DontDestroyMonoBehaviourSingleton<CameraHolder>
    {
        [SerializeField] private UnityEngine.Camera mainCamera;
        public CameraMoveControl cameraMoveControl;
        public UnityEngine.Camera MainCamera => mainCamera;
    }
}