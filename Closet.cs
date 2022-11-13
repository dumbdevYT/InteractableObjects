using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Closet : MonoBehaviour, IInteractable
    {
        [SerializeField] private GameObject closetUI;

        public string InteractText()
        {
            return "Change Appearance";
        }

        public Transform GetTransform()
        {
            return transform;
        }

        public void Interact(Transform interactorTransform)
        {
            OpenCloset();
        }

        private void OpenCloset()
        {
            Debug.Log("Opened Closet");
            closetUI.SetActive(true);
        }

    }

