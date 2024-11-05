using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerAnim : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public string triggerName; // The name of the trigger to activate
    public bool activateOnce = false; // If true, the trigger will only activate once
    bool hasActivated = false; // Flag to check if the trigger has already activated

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnTriggerEnter(Collider other)
    {       
        if (!hasActivated && other.CompareTag("Player")) // Check if the trigger has not activated and the player has entered the trigger area
        {
            if (animator != null)
            {
                animator.SetTrigger(triggerName); // Replace "TriggerName" with the actual trigger name
            }
            if (activateOnce)
        {
            hasActivated = true;
        }  
        }
        
    }

}
