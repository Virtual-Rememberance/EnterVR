using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel1 : MonoBehaviour
{
    public string level2scene = "MainLevel2";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(level2scene);

        }
    }
}
