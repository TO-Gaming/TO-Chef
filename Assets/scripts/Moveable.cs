using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moveable : MonoBehaviour
{
    [SerializeField]
    public float speed;
    [SerializeField]
    GameObject diceResText;
    TextMesh ans;
    public int Addscore = 0;
    private void Start()
    {
        if (this.tag == "LemonM2")
            Addscore = -2;
        if (this.tag == "Lemon3")
            Addscore = 3;
        if (this.tag == "Lemon1")
            Addscore = 1;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(-Vector3.right * Time.deltaTime * speed, Space.World);
    }
    void OnMouseUp()
    {
        ScoreScript.scoreValue += Addscore;
        Destroy(this.gameObject);
        //Taken();
    }
}

