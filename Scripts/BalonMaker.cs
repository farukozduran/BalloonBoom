using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonMaker : MonoBehaviour
{
    public GameObject ballon;
    float ballonTimer = 1f;
    float timeCounter = 0f;
    GameControl gcScript;
    // Start is called before the first frame update
    void Start()
    {
        gcScript = this.gameObject.GetComponent<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter -= Time.deltaTime;
        int constant = (int)(gcScript.timeCounter / 10) - 6;
        constant *= -1;
        if(timeCounter < 0 && gcScript.timeCounter > 0)
        {
            GameObject go = Instantiate(ballon,new Vector3(Random.Range(-7.34f,7.34f),-6f,0), Quaternion.Euler(0,0,0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(30f*constant,80f*constant),0));
            timeCounter = ballonTimer;
        }
    }
}
