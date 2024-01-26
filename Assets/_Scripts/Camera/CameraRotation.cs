using GreatestProject.CameraControl;
using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GreatestProject.CameraControl
{
    //[RequireComponent(typeof(ICameraContorl))]
    public class CameraRotation
    {
        [SerializeField] private ICameraContorl m_CameraContorl;
        public CameraRotation(ICameraContorl cameraContorl) 
        {
            m_CameraContorl = cameraContorl;
        }
        //[Button("旋转相机")]
        public void RotateCamera(Vector3 rotationDir)
        {
            //if (m_CameraContorl == null) //如果未设置CameraControl，则尝试从当前物体上找
            //{
            //    m_CameraContorl = GetComponent<ICameraContorl>();
            //}
            try
            {
                m_CameraContorl.cameraRoot.Rotate(rotationDir, Space.Self);
            }
            catch (NullReferenceException)
            {
                Debug.LogError("未找到CameraContorl");
                throw;
            }
        }
    }
}
