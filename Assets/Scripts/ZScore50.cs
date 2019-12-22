using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZScore50 : MonoBehaviour
{
    public GameObject ObjectiveComplete;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DeductPoints(int DamageAmount)
    {
        GlobalScore.CurrentScore += 50;
        ObjectiveComplete.SetActive(true);
    }
}
