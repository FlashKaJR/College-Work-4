using StarterAssets;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class KickImpact : MonoBehaviour
{
    public float pushForce = 10f;   
    public GameObject player;
    public GameObject playerPosition;
    public InputActionAsset playerInput;
    public InputActionAsset ragdollInput;
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
    public Rigidbody pelvisRoot;
    bool ragdoll;
    AudioSource audioSource;
    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = player.GetComponent<AudioSource>();
        }
    }

    void Update()
    {
        playerPosition.transform.position = hipsRigidbody.transform.position;
        if (ragdoll)
        {
            StartCoroutine(StopRagdoll());
            ragdoll = false;
        }
    }
    public void ActivateKick()
    {
        //Change input controller        
        PlayerInput PlayerInput = player.GetComponent<PlayerInput>();
        if (PlayerInput != null)
        {
            PlayerInput.actions = ragdollInput;
        }
        ragdoll = true;
        // Deactivate the animator
        if (playerAnimator != null)
        {
            playerAnimator.enabled = false;
        }

        // Apply force to the player       
        if (hipsRigidbody != null)
        {
            hipsRigidbody.isKinematic = false;
            hipsRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            hipsRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (leftUpLegRigidbody != null)
        {
            leftUpLegRigidbody.isKinematic = false;
            leftUpLegRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            leftArmRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (leftLegRigidbody != null)
        {
            leftLegRigidbody.isKinematic = false;
            leftLegRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            leftLegRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (leftFootRigidbody != null)
        {
            leftFootRigidbody.isKinematic = false;
            leftFootRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            leftFootRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (rightUpLegRigidbody != null)
        {
            rightUpLegRigidbody.isKinematic = false;
            rightUpLegRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            rightUpLegRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (rightLegRigidbody != null)
        {
            rightLegRigidbody.isKinematic = false;
            rightLegRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            rightLegRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (rightFootRigidbody != null)
        {
            rightFootRigidbody.isKinematic = false;
            rightFootRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            rightFootRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (spineRigidbody != null)
        {
            spineRigidbody.isKinematic = false;
            spineRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            spineRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (leftArmRigidbody != null)
        {
            leftArmRigidbody.isKinematic = false;
            leftArmRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            leftArmRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (leftForeArmRigidbody != null)
        {
            leftForeArmRigidbody.isKinematic = false;
            leftForeArmRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            leftForeArmRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (leftHandRigidbody != null)
        {
            leftHandRigidbody.isKinematic = false;
            leftHandRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            leftHandRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (headRigidbody != null)
        {
            headRigidbody.isKinematic = false;
            headRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            headRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (rightArmRigidbody != null)
        {
            rightArmRigidbody.isKinematic = false;
            rightArmRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            rightArmRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (rightForeArmRigidbody != null)
        {
            rightForeArmRigidbody.isKinematic = false;
            rightForeArmRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            rightForeArmRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (rightHandRigidbody != null)
        {
            rightHandRigidbody.isKinematic = false;
            rightHandRigidbody.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            rightHandRigidbody.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
        if (pelvisRoot != null)
        {
            pelvisRoot.isKinematic = false;
            pelvisRoot.AddForce(Vector3.back * pushForce, ForceMode.Impulse);
            pelvisRoot.AddForce(Vector3.up * pushForce, ForceMode.Impulse);
        }
    }
    //Activate anmimator and kinematic rigidbodies
    public void DeactivateKick()
    {
        //Change input controller        
        PlayerInput PlayerInput = player.GetComponent<PlayerInput>();
        if (PlayerInput != null)
        {
            PlayerInput.actions = playerInput;
        }
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
        if (pelvisRoot != null)
        {
            pelvisRoot.isKinematic = true;
        }
    }
    //Teleport player to rigidbody position
    public void TeleportPlayer()
    {
        Debug.Log("Teleporting player");
        player.transform.position = playerPosition.transform.position + new Vector3(0, 0.2f, 0);
    }

    private IEnumerator StopRagdoll()
    {
        yield return new WaitForSeconds(0.5f);
        audioSource.Play();
        yield return new WaitForSeconds(4);
        DeactivateKick();
    }
}
