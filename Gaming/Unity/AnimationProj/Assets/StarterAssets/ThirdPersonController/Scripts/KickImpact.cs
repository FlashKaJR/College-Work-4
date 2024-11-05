using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickImpact : MonoBehaviour
{
       public float pushForce = 10f;
       public bool push;
       public bool standUp;
       public GameObject player;
       public GameObject playerPosition;
    public Animator playerAnimator;
    public Rigidbody hipsRigidbody;
    public Rigidbody leftUpLegRigidbody;
    public Rigidbody leftLegRigidbody;
    public Rigidbody leftFootRigidbody;
    public Rigidbody rightUpLegRigidbody;
    public Rigidbody rightLegRigidbody;
    public Rigidbody rightFootRigidbody;
    public Rigidbody spineRigidbody;
    public Rigidbody leftArmRigidbody;
    public Rigidbody leftForeArmRigidbody;
    public Rigidbody leftHandRigidbody;
    public Rigidbody headRigidbody;
    public Rigidbody rightArmRigidbody;
    public Rigidbody rightForeArmRigidbody;
    public Rigidbody rightHandRigidbody;




    void Update()
    {
        playerPosition.transform.position = hipsRigidbody.transform.position;
        if (push)
        {
            ActivateKick();
            push = false;
        }
        if (standUp)
        {
            DeactivateKick();
            standUp = false;
        }
    }
    public void ActivateKick()
    {
        // Deactivate the animator
        if (playerAnimator != null)
        {
            playerAnimator.enabled = false;
        }

        // Apply force to the player       
        if (hipsRigidbody != null)
        {
            hipsRigidbody.isKinematic = false;
            hipsRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (leftUpLegRigidbody != null)
        {
            leftUpLegRigidbody.isKinematic = false;
            leftUpLegRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (leftLegRigidbody != null)
        {
            leftLegRigidbody.isKinematic = false;
            leftLegRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (leftFootRigidbody != null)
        {
            leftFootRigidbody.isKinematic = false;
            leftFootRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (rightUpLegRigidbody != null)
        {
            rightUpLegRigidbody.isKinematic = false;
            rightUpLegRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (rightLegRigidbody != null)
        {
            rightLegRigidbody.isKinematic = false;
            rightLegRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (rightFootRigidbody != null)
        {
            rightFootRigidbody.isKinematic = false;
            rightFootRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (spineRigidbody != null)
        {
            spineRigidbody.isKinematic = false;
            spineRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (leftArmRigidbody != null)
        {
            leftArmRigidbody.isKinematic = false;
            leftArmRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (leftForeArmRigidbody != null)
        {
            leftForeArmRigidbody.isKinematic = false;
            leftForeArmRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (leftHandRigidbody != null)
        {
            leftHandRigidbody.isKinematic = false;
            leftHandRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (headRigidbody != null)
        {
            headRigidbody.isKinematic = false;
            headRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (rightArmRigidbody != null)
        {
            rightArmRigidbody.isKinematic = false;
            rightArmRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (rightForeArmRigidbody != null)
        {
            rightForeArmRigidbody.isKinematic = false;
            rightForeArmRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
        if (rightHandRigidbody != null)
        {
            rightHandRigidbody.isKinematic = false;
            rightHandRigidbody.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
        }
    }
    //Activate anmimator and kinematic rigidbodies
    public void DeactivateKick()
    {
        TeleportPlayer();
        // Activate the animator
        if (playerAnimator != null)
        {
            playerAnimator.enabled = true;
        }

        // Deactivate the kinematic rigidbodies
        if (hipsRigidbody != null)
        {
            hipsRigidbody.isKinematic = true;
        }
        if (leftUpLegRigidbody != null)
        {
            leftUpLegRigidbody.isKinematic = true;
        }
        if (leftLegRigidbody != null)
        {
            leftLegRigidbody.isKinematic = true;
        }
        if (leftFootRigidbody != null)
        {
            leftFootRigidbody.isKinematic = true;
        }
        if (rightUpLegRigidbody != null)
        {
            rightUpLegRigidbody.isKinematic = true;
        }
        if (rightLegRigidbody != null)
        {
            rightLegRigidbody.isKinematic = true;
        }
        if (rightFootRigidbody != null)
        {
            rightFootRigidbody.isKinematic = true;
        }
        if (spineRigidbody != null)
        {
            spineRigidbody.isKinematic = true;
        }
        if (leftArmRigidbody != null)
        {
            leftArmRigidbody.isKinematic = true;
        }
        if (leftForeArmRigidbody != null)
        {
            leftForeArmRigidbody.isKinematic = true;
        }
        if (leftHandRigidbody != null)
        {
            leftHandRigidbody.isKinematic = true;
        }
        if (headRigidbody != null)
        {
            headRigidbody.isKinematic = true;
        }
        if (rightArmRigidbody != null)
        {
            rightArmRigidbody.isKinematic = true;
        }
        if (rightForeArmRigidbody != null)
        {
            rightForeArmRigidbody.isKinematic = true;
        }
        if (rightHandRigidbody != null)
        {
            rightHandRigidbody.isKinematic = true;
        }
    }
    //Teleport player to rigidbody position
    public void TeleportPlayer()
    {
        Debug.Log("Teleporting player");
        player.transform.position += playerPosition.transform.position;
    }
  
}
