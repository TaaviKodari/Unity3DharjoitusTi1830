using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hahmoOhjain : MonoBehaviour
{
    public float juoksuNopeus = 3f;
    public float hiirenNopeus = 3f;

    private float vertikaaliPyorinta = 0f;
    private float horisontaalinenPyorinta = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horisontaalinenPyorinta += Input.GetAxis("Mouse X") * hiirenNopeus;
        vertikaaliPyorinta  += Input.GetAxis("Mouse Y") * hiirenNopeus;
        Camera.main.transform.localRotation = Quaternion.Euler(vertikaaliPyorinta,horisontaalinenPyorinta,0);
    }
}
