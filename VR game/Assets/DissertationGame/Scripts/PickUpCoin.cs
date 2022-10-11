using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour
{

    public GameObject PickedUpTxt;
    [SerializeField] private GameController gameController;

    private void Awake()
    {
        gameController = FindObjectOfType<GameController>();
    }

    public void Start()
    {
        PickedUpTxt.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Cube"))
        {
            PickedUpTxt.SetActive(true);
            gameController.UpdateCoinScore();
            Destroy(other.gameObject);
            StartCoroutine(WaitForSec());
        }
    }

    public IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(2);
        PickedUpTxt.SetActive(false);
    }

    /*
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");

        if (collision.gameObject.CompareTag("Cube"))
        {
            Destroy(this.gameObject);
        }
    }
    */
}
