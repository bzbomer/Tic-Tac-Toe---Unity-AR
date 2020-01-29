using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour
{

    public float x, y, z;
    public float scalex, scaley, scalez;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.Rotate(x, y, z, Space.Self);
        transform.localScale = new Vector3(scalex, scaley, scalez);

    }
}
