using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public int EnemyHealth = 10;
    public GameObject TheZombie;

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
            this.GetComponent<ZombieFollow>().enabled = false;
            TheZombie.GetComponent<Animation>().Play("Dying");
            StartCoroutine(EndZombie());
        }
    }

    IEnumerator EndZombie()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);

    }
}
