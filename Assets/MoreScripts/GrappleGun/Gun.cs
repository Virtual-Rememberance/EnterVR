using UnityEngine;
using UnityEngine.UIElements.Experimental;
using System.Threading.Tasks;

public class Gun : MonoBehaviour
{

    public Transform playerCam;
    public CharacterController charController;
    public float pullSpeed = 5f;

    public GameObject plunger;

    private bool isPulling = false;
    private Vector3 pullLocation;

    [SerializeField] Transform barrel;

    public float plungerSpeed;

    Transform plungerPos;

    Rigidbody plungerRB;

    Plunger plungerScript;

    LineRenderer rope;



    public bool hasBeenShot { get; set; }

    public void Start()
    {
        plungerPos = plunger.transform;
        plungerRB = plunger.GetComponent<Rigidbody>();
        plungerScript = plunger.GetComponent<Plunger>();

        rope = GetComponent<LineRenderer>();
        rope.positionCount = 2;
    }

   public void Update()
    {
        if (!hasBeenShot)
        {
            plungerPos.position = barrel.position;
            plungerPos.forward = barrel.forward;
        }

        if (hasBeenShot)
        {
            rope.enabled = true;
            rope.SetPosition(0, barrel.position);
            rope.SetPosition(1, plunger.transform.position);
        }
        else
        {
            rope.enabled = false;
        } 


        if (isPulling)
        {
            Vector3 direction = (pullLocation - playerCam.position);
            float distance = direction.magnitude;

            if (distance > 0.2f)
            {
                direction.Normalize();
                charController.Move(direction * pullSpeed * Time.deltaTime);
                
            }
            else
            {
                charController.Move(direction);
                isPulling = false;

                plunger.transform.position = barrel.position;
                plunger.transform.forward = barrel.forward;
            }

            
        }
    }

   public void Fire()
   {
        hasBeenShot = true;
        plungerPos.position = barrel.position;
        plungerRB.linearVelocity = barrel.forward * plungerSpeed;

   }

   public void CancelFire()
   {
        hasBeenShot = false;
        plungerScript.DestroyJoint();
        
        if (plungerScript.isGrappling == true)
        {
            PullPlayer();
        }
   } 

    public async void PullPlayer()
    {
        plungerRB.linearVelocity = Vector3.zero;

        pullLocation = plunger.transform.position;
        isPulling = true;
        await Task.Delay(3000);
        isPulling = false;
        hasBeenShot = false;
    }
}
