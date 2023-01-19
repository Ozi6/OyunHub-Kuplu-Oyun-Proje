using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    Vector3 pos;
    [SerializeField]
    private float ZSpeed;
    [SerializeField]
    private float XSpeed;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * XSpeed * Time.deltaTime;
        this.transform.Translate(horizontal, 0, ZSpeed * Time.deltaTime);
    }
}
