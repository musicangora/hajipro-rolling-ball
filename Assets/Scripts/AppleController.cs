using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour
{
    public GameObject particleObject;
    public GameObject GameManager;
    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag=="Ball")
        {
            Instantiate(particleObject, this.transform.position, Quaternion.identity);
            _gameManager.SubScore(1);  // りんごの残り個数を更新
            Destroy(gameObject);
        }
    }
}
