using System;
using System.Collections;
using System.Collections.Generic;
using Valve.VR.InteractionSystem;
using UnityEngine;

public class GrappleGun : MonoBehaviour {
    public LineRenderer cable;
    public Hand hand;
    public Rigidbody player;
    private Ray ray;
    private RaycastHit hit;
    private Vector3 grapplePoint;

    void Update () {
        if (TriggerPressDown(hand))
        {
            if (Physics.Raycast(hand.transform.position, hand.transform.forward, out hit))
            {
                cable.enabled = true;
                cable.SetPosition(0, hand.transform.position);
                cable.SetPosition(1, hit.point);

                grapplePoint = hit.point;
                player.AddForce((grapplePoint - hand.transform.position).normalized * 25f);
            }
        }
        else if (TriggerPressed(hand) && cable.enabled)
        {
            cable.SetPosition(0, hand.transform.position);
            player.AddForce((grapplePoint - hand.transform.position).normalized * 25f);
        }
        else if (TriggerRelease(hand))
        {
            cable.enabled = false;
        }
        else
        {
            if (Physics.Raycast(hand.transform.position, hand.transform.forward, out hit))
            {
                //TODO: Implement aiming reticle (milestone 2 feature)
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
}
