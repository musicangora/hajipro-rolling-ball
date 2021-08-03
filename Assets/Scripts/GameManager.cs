using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text CountText;
    public GameObject ClearText;
    public int appleCount = 5;
    // Start is called before the first frame update
    void Start()
    {
        ClearText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CountText.text = appleCount.ToString();
        if (appleCount <= 0)
        {
            ClearText.SetActive(true);
        }
    }

    public void SubScore(int val)
    {
        appleCount -= val;
    }
}
