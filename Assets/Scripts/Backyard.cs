using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backyard : MonoBehaviour
{
    public GameObject AlleyThing;

    public GameObject FrameAlley1;
    public GameObject FrameAlley3;

    public GameObject MarkSays1;
    public GameObject MarkSays2;
    public GameObject MarkSays3;

    public GameObject MarkSaw1;

    public GameObject EndScreen;

    public GameObject ChillSound;
    public GameObject AlleySound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        {
            AlleyThing.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        {
            AlleyThing.SetActive(false);
        }
    }
    public void YesAlley()
    {
        FrameAlley3.SetActive(true);
        MarkSays1.SetActive(true);
        ChillSound.SetActive(false);
        AlleySound.SetActive(true);
        StartCoroutine(StartAlley());
    }
    public IEnumerator StartAlley()
    {
        yield return new WaitForSeconds(4.0f);
        FrameAlley3.SetActive(false);
        MarkSays1.SetActive(false);
        FrameAlley1.SetActive(true);
        MarkSays2.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        FrameAlley3.SetActive(true);
        MarkSays3.SetActive(true);
        MarkSays2.SetActive(false);
        FrameAlley1.SetActive(false);
        yield return new WaitForSeconds(4.0f);
        FrameAlley3.SetActive(false);
        MarkSays3.SetActive(false);
        AlleySound.SetActive(false);
        MarkSaw1.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        EndScreen.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(0);
    }
    public void NoAlley()
    {
        AlleyThing.SetActive(false);
    }
}
