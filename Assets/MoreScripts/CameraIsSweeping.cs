using UnityEngine;

public class CameraIsSweeping : MonoBehaviour
{
    [SerializeField] private bool isSweeping;
    [SerializeField] private Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (isSweeping)
        {
            anim.SetBool("isSweeping", true);
        }
        if (!isSweeping)
        {
            anim.SetBool("isSweeping", false);
        }
    }
}
