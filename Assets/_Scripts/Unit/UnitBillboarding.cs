using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GreatestProject.Unit
{
    public class UnitBillboarding : MonoBehaviour
    {
        [SerializeField] private Transform _nowCamera;

        public Transform nowCamera
        {
            set { _nowCamera = value; }
            get { return _nowCamera; }
        }
        private void UpdateRotation()
        {
            transform.rotation = _nowCamera.rotation;
        }
    }
}
