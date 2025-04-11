using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using static System.Net.Mime.MediaTypeNames;

public class YarnInteractable : MonoBehaviour
{
    // this file is attached to every character in the scene and so will affect only
    // the targeted character object when functions are called

    // first we need a handle on the DialogueRunner, so we may as well get it when
    // this object is first added to the scene
    private DialogueRunner dialogueRunner;

    public void Start()
    {
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        dialogueRunner.onDialogueComplete.AddListener(EndConversation);
    }

    // then we need a function to tell Yarn Spinner to start from {specifiedNodeName}
    public string conversationStartNode;

    private bool isCurrentConversation;

    // disable scene interaction, activate speaker indicator, and
    // run dialogue from {conversationStartNode}
    private void StartConversation()
    {
        isCurrentConversation = true;
        // TODO *begin animation or turn on speaker indicator or whatever* HERE
        dialogueRunner.StartDialogue(conversationStartNode);
    }

    // reverse StartConversation's changes: 
    // re-enable scene interaction, deactivate indicator, etc.
    private void EndConversation()
    {
        if (isCurrentConversation)
        {
            // TODO *stop animation or turn off indicator or whatever* HERE
            isCurrentConversation = false;
        }
    }

    public bool interactable = true; // whether this character should be enabled right now
                               // (begins true, but may not always be true)

    void OnMouseDown()
    {
        Debug.Log($"Clicked {gameObject.name}");
        Debug.Log($"Interactable: {interactable}");
        Debug.Log($"Is Dialogue Running: {dialogueRunner.IsDialogueRunning}");
        // if this character is enabled and no conversation is already running
        if (interactable && !dialogueRunner.IsDialogueRunning)
        {
            // then run this character's conversation
            StartConversation();
        }
    }

    // make character not able to be clicked on
    [YarnCommand("disable")]
    public void DisableConversation()
    {
        interactable = false;
    }

    
}
