using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableGrabbingHandComponent : MonoBehaviour
{
    //He has a tutorial where I can add a grabing posse instead ***Need to watch that Later On**
    public GameObject leftHandModel;
    public GameObject rightHandModel;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideGrabbingHand);
        grabInteractable.selectExited.AddListener(ShowGrabbingHand);

    }

    public void HideGrabbingHand(SelectEnterEventArgs args)
    {
        if(args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(false);
        }
        else if(args.interactorObject.transform.tag == "Right Hand")
        {
            rightHandModel.SetActive(false);
        }
    }

    public void ShowGrabbingHand(SelectExitEventArgs args)
    {
        if (args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(true);
        }
        else if (args.interactorObject.transform.tag == "Right Hand")
        {
            rightHandModel.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
