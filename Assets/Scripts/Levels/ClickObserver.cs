using System;
using Camera;
using Connection;
using Events;
using Player.ActionHandlers;
using UnityEngine;

namespace Levels
{
    public class ClickObserver : MonoBehaviour
    {
        [SerializeField] private ColorConnectionManager colorConnectionManager;

        private ClickHandler _clickHandler;

        private void Awake()
        {
            _clickHandler = ClickHandler.Instance;

            _clickHandler.PointerDownEvent += OnPointerDown;
            _clickHandler.PointerUpEvent += OnPointerUp;
            _clickHandler.ClickOnEmptySpace += ClickOnEmptySpace;
        }


        private void OnDestroy()
        {
            _clickHandler.PointerDownEvent -= OnPointerDown;
            _clickHandler.PointerUpEvent -= OnPointerUp;
            _clickHandler.ClickOnEmptySpace -= ClickOnEmptySpace;
        }

        private void OnPointerDown(Vector3 position)
        {
            colorConnectionManager.TryGetColorNodeInPosition(position, out var node);

            if (node != null)
                EventsController.Fire(new EventModels.Game.NodeTapped());
        }

        private void OnPointerUp(Vector3 position)
        {
            EventsController.Fire(new EventModels.Game.PlayerFingerRemoved());
        }

        private void ClickOnEmptySpace()
        {
            Vector3 newCameraPosition = colorConnectionManager.GetNewStagePosition().position;
            CameraHolder.Instance.cameraMoveControl.MoveCameraToPoint(newCameraPosition);
        }
    }
}