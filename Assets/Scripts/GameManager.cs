using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text CountText;
    public GameObject ClearText;
    public int appleCount = 5;
    private string _sceneName;
    // Start is called before the first frame update
    void Start()
    {
        ClearText.SetActive(false);
        _sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        CountText.text = appleCount.ToString();
        if (appleCount <= 0)
        {
            ClearText.SetActive(true);
            StartCoroutine(Restart());  // コルーチンで2秒待ってからリスタート
        }
    }

    public void SubScore(int val)
    {
        appleCount -= val;
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(_sceneName);
    }
}
