using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GiveDocument : MonoBehaviour
{
    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject TextDisplay;

    public GameObject document;
    
    public GameObject ObjectiveComplete;
    
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }
    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            TextDisplay.GetComponent<Text>().text = "Put document";
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                StartCoroutine(TakeDocument());
            }
        }
    }
    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator TakeDocument()
    {
        
        transform.position = new Vector3(0, -1000, 0);
        
        document.SetActive(true);
        ObjectiveComplete.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(7);
    }
}
