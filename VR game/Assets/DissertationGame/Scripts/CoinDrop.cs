using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDrop : MonoBehaviour
{

    [SerializeField] private GameObject CoinModel;
    [SerializeField] private GameController gameController;

    private void Awake()
    {
        gameController = FindObjectOfType<GameController>();
    }

    public void DropCoin()
    {

        //pass score to GameController
        gameController.UpdateCubeScore();

        Destroy(this.gameObject);
        Vector3 position = transform.position;
        GameObject coin = Instantiate(CoinModel, position, Quaternion.identity);
        coin.SetActive(true);
        Destroy(coin, 6f);


    }

}
