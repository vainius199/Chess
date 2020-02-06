using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    private Animator anim;
    
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void DeathAnim()
    {
       
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.5f);
        
        StartCoroutine("Wait");
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.5f);
        anim.Play("knight_die");
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        
    }

}
