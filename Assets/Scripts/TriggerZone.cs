using UnityEngine;
using System.Collections;

public class TriggerZone : MonoBehaviour
{
    public GameObject HouseThing;
    public GameObject neighborScreen; 
    public GameObject slamScreen;
    public GameObject DoorSound;
    public GameObject StartFramelol;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        {
            HouseThing.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        {
            HouseThing.SetActive(false);
        }
    }
    public void YesHouse()
    {
        neighborScreen.SetActive(true);
        StartCoroutine(SlamRoutine());
    }
    public IEnumerator SlamRoutine()
    {
        yield return new WaitForSeconds(2.0f);
        neighborScreen.SetActive(false);
        slamScreen.SetActive(true);
        DoorSound.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        slamScreen.SetActive(false);
        DoorSound.SetActive(false);
        HouseThing.SetActive(false);
    }
    public void NoNCloseHouse()
    {
        HouseThing.SetActive(false);
    }
    public void Start()
    {
        StartCoroutine(StartFrames());
    }
    public IEnumerator StartFrames()
    {
        yield return new WaitForSeconds(4.0f);
        StartFramelol.SetActive(false);
    }
}