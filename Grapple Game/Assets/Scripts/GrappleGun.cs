using Valve.VR.InteractionSystem;
using UnityEngine;

public class GrappleGun : MonoBehaviour {
    public LineRenderer cable;
    public Hand hand;
    public Rigidbody player;
    public GameObject aimingReticle;

    private GameObject reticle;
    private RaycastHit hit;
    private Vector3 grapplePoint;

    private bool pickup;

    private void Start()
    {
        reticle = Instantiate(aimingReticle);
    }

    void FixedUpdate () {
        if (pickup) //Disable grapple on pickup  
        {
            reticle.SetActive(false);
        }
        else if (TriggerPressDown(hand)) //Initial Grapple, setting of linerender properties
        {
            if (Physics.Raycast(hand.transform.position, hand.transform.forward, out hit))
            {
                reticle.SetActive(false);
                cable.enabled = true;
                cable.SetPosition(0, hand.transform.position);
                cable.SetPosition(1, hit.point);

                grapplePoint = hit.point;
                player.AddForce((grapplePoint - hand.transform.position).normalized * 25.0f);
            }
        }
        else if (TriggerPressed(hand) && cable.enabled) //Continue Grapple, update of linerender properties
        {
            cable.SetPosition(0, hand.transform.position);
            player.AddForce((grapplePoint - hand.transform.position).normalized * 25.0f);
        }
        else if (TriggerRelease(hand)) //Stop Grapple
        {
            cable.enabled = false;
        }
        else //Display Reticle
        {
            if (Physics.Raycast(hand.transform.position, hand.transform.forward, out hit) && !pickup)
            {
                reticle.SetActive(true);
                reticle.transform.position = hit.point;
            }
            else
            {
                reticle.SetActive(false);
            }
        }
    }

    private bool TriggerPressDown(Hand hand)
    {
        return hand.controller.GetPressDown(SteamVR_Controller.ButtonMask.Trigger);
    }

    private bool TriggerPressed(Hand hand)
    {
        return hand.controller.GetPress(SteamVR_Controller.ButtonMask.Trigger);
    }

    private bool TriggerRelease(Hand hand)
    {
        return hand.controller.GetPressUp(SteamVR_Controller.ButtonMask.Trigger);
    }

    private void OnTriggerEnter(Collider other)   //block is on pressure plate
    {
        if (other.gameObject.CompareTag("pressurePlateBox"))
        {
            pickup = true;
        }
    }

    private void OnTriggerExit(Collider other) //block comes off pressure plate
    {
        if (other.gameObject.CompareTag("pressurePlateBox"))
        {
            pickup = false;
        }
    }
}
