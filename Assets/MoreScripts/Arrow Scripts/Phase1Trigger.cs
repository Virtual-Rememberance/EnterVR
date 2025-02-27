using UnityEngine;

public class Phase1Trigger : MonoBehaviour
{
    public GameObject[] itemsToToggle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject item in itemsToToggle)
            {
                if (item != null)
                {
                    item.SetActive(!item.activeSelf);
                }
            }
        }
    }
}


