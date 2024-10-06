using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Lab3
{
    [RequireComponent(typeof(Collider))]
    public class cameratrigger : MonoBehaviour
    {
        [SerializeField] private CinemachineVirtualCamera cam;
        private Collider trigger;

        private void Awake()
        {
            trigger = GetComponent<Collider>();
            trigger.isTrigger = true;
            cam.gameObject.SetActive(false);
        }

        public void ActivateCamera(bool active)
        {
            Debug.Log($"VirtualCam {gameObject.name} set to {active}");
            cam.gameObject.SetActive(active);
        }
    }
}