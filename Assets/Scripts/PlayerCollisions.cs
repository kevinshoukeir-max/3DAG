using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Door Animator
    [SerializeField] private GameObject door; // An open slo in the Inspector to drag the hinge object into 

    Animator doorAnimator;

    // Door timer
    [Header("Door timer")]
    private bool startDoorTimer = false;
    private float doorTimer = 0.0f;
    [SerializeField] private float doorOpenTime = 3.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        doorAnimator = door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Run a door timer
        if(startDoorTimer)
        {
            doorTimer += Time.deltaTime;
        }

        // Automatically shut door after timer
        if(doorTimer >= doorOpenTime)
        {
            ShutDoor(); // This calls the custom method below

            doorTimer = 0.0f;
        }
    }

    // Collision detection
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Check if the player hits an object with the houseDoor tag
        if(hit.gameObject.CompareTag("houseDoor"))
        {
            // print("Hit the door!");
            OpenDoor();
        }
    }

    // Custom open door method
    private void OpenDoor()
    {
        // Set Animator parameters
        doorAnimator.SetBool("doorOpen", true);

        startDoorTimer = true;
    }

    // Custom shut door method
    private void ShutDoor()
    {
        // Set Animator parameters
        doorAnimator.SetBool("doorOpen", false);
    }
}
