using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private GameObject doorObject;

    private Animator Left_Door;
    private Animator Right_Door;

    private AudioSource Open_DoorSFX;
    private AudioSource Close_DoorSFX;

    private void OnTriggerEnter(Collider door)
    {
        if (door.tag == "Door")
        {
            Debug.Log("Player Entered");

            doorObject = door.gameObject;

            openDoor();
            AudioGrabber();

            Open_DoorSFX.Play();
        }
    }

    private void OnTriggerExit(Collider door)
    {
        if (door.tag == "Door")
        {
            Debug.Log("Player Exited");

            closeDoor();
            AudioGrabber();

            Close_DoorSFX.Play();
        }
    }

    private void openDoor()
    {
        Left_Door = doorObject.transform.GetChild(0).GetComponent<Animator>();
        Right_Door = doorObject.transform.GetChild(1).GetComponent<Animator>();

        Left_Door.SetBool("playerClose", true);
        Right_Door.SetBool("playerClose", true);

        
    }

    private void closeDoor()
    {
        Left_Door = doorObject.transform.GetChild(0).GetComponent<Animator>();
        Right_Door = doorObject.transform.GetChild(1).GetComponent<Animator>();

        Left_Door.SetBool("playerClose", false);
        Right_Door.SetBool("playerClose", false);

        
    }

    private void AudioGrabber()
    {
        Open_DoorSFX = doorObject.transform.GetChild(2).GetChild(0).GetComponent<AudioSource>();
        Close_DoorSFX = doorObject.transform.GetChild(2).GetChild(1).GetComponent<AudioSource>();
    }
}

