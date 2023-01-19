using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplanabilir : MonoBehaviour
{
    bool tahsilEdilmek;
    int index;
    public tahsildar tahsildar;

    // Start is called before the first frame update
    void Start()
    {
        tahsilEdilmek = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(tahsilEdilmek == true)
        {
            
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Blok")
        {
            tahsildar.BoyAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }


    public bool Tahsilat()
    {
        return tahsilEdilmek;
    }
    public void TahsilEt()
    {
        tahsilEdilmek = true;
    }
    public void IndexAyarla(int index)
    {
        this.index = index;
    }
}
