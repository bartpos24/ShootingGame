using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZScore25 : MonoBehaviour
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
        GlobalScore.CurrentScore += 25;
        ObjectiveComplete.SetActive(true);
    }
}
