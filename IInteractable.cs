using UnityEngine;


    public interface IInteractable
    {
        void Interact(Transform interactorTransform);
        string InteractText();
        Transform GetTransform();
    }
