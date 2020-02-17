using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBox : MonoBehaviour
{
    public Rigidbody rg;
    Vector3 boxEular;
    bool isFix = false;
    [SerializeField] float jumbForce = 10;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //ここで動く
        if (Input.anyKey)
            Boxmove();
        //キューブを常に正しい角度にしたい
        FixEular();
    }

    private void Boxmove()
    {
        //move around direction by input key!
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, 0, 0.01f);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, 0, -0.01f);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-0.01f, 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(0.01f, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Press Space");
            rg.AddForce(0, jumbForce, 0);
        }
    }
    void FixEular()
    {
        if (isFix)
        {
            Debug.LogWarning("角度を直しています");
            boxEular = transform.localEulerAngles;
            if (boxEular.x != 0)
                if (boxEular.x < 0)
                    boxEular.x += 1f;
                else
                    boxEular.x += 1f;
            if (boxEular.z != 0)
                if (boxEular.z < 0)
                    boxEular.z += 1f;
                else
                    boxEular.z += 1f;
            transform.localEulerAngles = boxEular;
            if (boxEular.x < 44 && boxEular.x >-44 && boxEular.z < 44 && boxEular.z > -44)
            {
                isFix = false;
                Debug.Log("end!!!");
            }
        }
    }
    public void OnClick()
    {
        isFix = true;
    }
}
