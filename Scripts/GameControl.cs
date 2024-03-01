using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public UnityEngine.UI.Text timeText, ballonText;
    public UnityEngine.UI.Button btn;
    public GameObject boom;
    public float timeCounter = 10;
    int boomedBallon = 0;
    // Start is called before the first frame update
    void Start()
    {
        ballonText.text = "Balloon : " + boomedBallon;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeCounter > 0)
        {
            timeCounter -= Time.deltaTime;
            timeText.text = "Time : " + (int)timeCounter;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("Ballon");
            for(int i = 0; i < go.Length; i++)
            {
                Instantiate(boom, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
                
            }
            btn.gameObject.SetActive(true);
        }
    }
    public void AddBallon()
    {
        boomedBallon++;
        ballonText.text = "Balloon : " + boomedBallon;
    }
}
//