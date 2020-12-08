using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hahmoOhjain : MonoBehaviour
{
    public float juoksuNopeus = 3f;
    public float hiirenNopeus = 3f;
    public float maxKaannosAsteet = 60f;
    public CursorLockMode haluttuMoodi;
    public CharacterController controller;
    private float vertikaaliPyorinta = 0f;
    private float horisontaalinenPyorinta = 0f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

        Cursor.lockState = haluttuMoodi;
        Cursor.visible = (CursorLockMode.Locked != haluttuMoodi);
    }

    // Update is called once per frame
    void Update()
    {
        horisontaalinenPyorinta += Input.GetAxis("Mouse X") * hiirenNopeus;
        vertikaaliPyorinta  -= Input.GetAxis("Mouse Y") * hiirenNopeus;
        vertikaaliPyorinta = Mathf.Clamp(vertikaaliPyorinta,-maxKaannosAsteet,maxKaannosAsteet);
        Camera.main.transform.localRotation = Quaternion.Euler(vertikaaliPyorinta,horisontaalinenPyorinta,0);

        float nopeuseteen = Input.GetAxis("Vertical");
        float nopeussivulle  = Input.GetAxis("Horizontal");
        Vector3 nopeus = new Vector3(nopeussivulle,0,nopeuseteen) * juoksuNopeus;
        nopeus = transform.rotation * nopeus;
        controller.SimpleMove(nopeus);
    }
}
