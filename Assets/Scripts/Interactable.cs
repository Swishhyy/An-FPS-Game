using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public abstract class Interactable : MonoBehaviour
{
    //Add or remove an unteraction even component to this game object
    public bool useEvents;
    [SerializeField]
    public string promptMessage;

    public virtual string OnLook()
    {
        return promptMessage;
    }

    //this function will be called from our player
    public void BaseInteract()
    {
        if(useEvents)
        {
            GetComponent<InteractionEvent>().onInteract.Invoke();
        }
        Interact();
    }

    protected virtual void Interact()
    {
        //no code to add this is a template script
    }
}
