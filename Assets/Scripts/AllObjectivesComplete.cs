using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllObjectivesComplete : MonoBehaviour
{
    public GameObject objectives1;
    public GameObject objectives2;
    public GameObject objectives3;
    void Update()
    {
        if ((objectives1 == true) && (objectives2 == true) & (objectives3 == true))
        {
            SceneManager.LoadScene(7);
        }
        
    }
}
