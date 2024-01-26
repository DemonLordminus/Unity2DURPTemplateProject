using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GreatestProject.CameraControl
{
    public class CameraGroup : MonoBehaviour,ICameraContorl
    {
        [SerializeField] private Cinemachine.CinemachineVirtualCamera _virtualCam;
        [SerializeField] private UnityEngine.Camera _camera;

        public Transform cameraRoot => transform;
        public Cinemachine.CinemachineVirtualCamera virtualCam
        {
            get
            {
                return _virtualCam;
            }
        }
        public Camera nowCamera
        {
            get
            { return _camera; }
        }

    }
}
