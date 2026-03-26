using System.Collections;
using TMPro;
using UnityEngine;

public class KeypadController : MonoBehaviour
{
    [SerializeField] private Animator doorAnim = null;
    private bool doorOpen = false;
    [SerializeField] private float doorCooldownRate = 1f;
    public float doorCooldown = 0f;
        public bool doorProcessing = false;
    
    public void Interact()

        {
            if (!doorOpen && !doorProcessing)
            {
                doorAnim.Play("Open", 0, 0f);
                doorOpen = true;
                StartCoroutine(StartDoorCooldown());
            }
            else if (doorOpen && !doorProcessing)
            {
                doorAnim.Play("Close", 0, 0f);
                doorOpen = false;
                StartCoroutine(StartDoorCooldown());
            }
        }

    IEnumerator StartDoorCooldown()
    {
        doorCooldown = doorCooldownRate;
        doorProcessing = true;
        yield return new WaitForSeconds(doorCooldown);
        doorProcessing = false;

    }
}

