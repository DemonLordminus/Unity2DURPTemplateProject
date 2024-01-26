using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GreatestProject.CameraControl
{
    public interface ICameraContorl
    {
        public Camera nowCamera
        { get; }
        public Transform cameraRoot
        { get; }
    }
}
