using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonControl : MonoBehaviour
{
    public GameObject boom;
    GameControl gameControlScript;

    private void Start()
    {
        gameControlScript = GameObject.Find("_Scripts").GetComponent<GameControl>();
    }
    private void OnMouseDown()
    {
        GameObject go = Instantiate(boom,transform.position,transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.267f);
        gameControlScript.AddBallon();
    }
}
