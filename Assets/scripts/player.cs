using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Lab3
{
    public class PlayerWalk : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private CharacterController controller;
        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        private void Update()
        {
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));

            Vector3 move = transform.forward * Input.GetAxis("Vertical") +
                transform.right * Input.GetAxis("Horizontal");

            controller.Move(move * speed * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            cameratrigger trigger = other.GetComponent<cameratrigger>();
            if (trigger != null)
            {
                trigger.ActivateCamera(true);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            cameratrigger trigger = other.GetComponent<cameratrigger>();
            if (trigger != null)
            {
                trigger.ActivateCamera(false);
            }
        }
    }
}