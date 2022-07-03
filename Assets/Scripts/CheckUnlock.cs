using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUnlock : MonoBehaviour
{
    public Animator anim;
    public GameObject key;
    public GameObject door = null;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Key"))
        {
            anim.SetBool("isOpen", true);
            key.SetActive(false);

        }
    }
}
