using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tahsildar : MonoBehaviour
{
    GameObject Hold;
    int boy;
    // Start is called before the first frame update
    void Start()
    {
        Hold = GameObject.Find("Hold");
    }

    // Update is called once per frame
    void Update()
    {
        Hold.transform.position = new Vector3(transform.position.x, boy + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -boy, 0);
    }
    public void BoyAzalt()
    {
        boy--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Toplanacak"&&other.gameObject.GetComponent<toplanabilir>().Tahsilat()==false)
        {
            boy += 1;
            other.gameObject.GetComponent<toplanabilir>().TahsilEt();
            other.gameObject.GetComponent<toplanabilir>().IndexAyarla(boy);
            other.gameObject.transform.parent = Hold.transform;
        }
    }
}
