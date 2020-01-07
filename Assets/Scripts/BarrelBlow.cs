using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelBlow : MonoBehaviour
{

    public int EnemyHealth = 5;
    public GameObject TheBarrel;
    public GameObject FakeBarrel;

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0)
        {
            TheBarrel.SetActive(false);
            FakeBarrel.SetActive(true);
        }
    }

    /*IEnumerator EndZombie()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);

    }
    */
}
