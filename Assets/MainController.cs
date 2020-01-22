using UnityEngine;

public class MainController : MonoBehaviour {

    public GameObject mTrigger, mBackTrigger;

    void OnTriggerEnter(Collider other) {

        if (other.CompareTag("front"))
            mTrigger.SetActive(true);
            Debug.Log("Front");
               
        if (other.CompareTag("back"))
            mBackTrigger.SetActive(true);
            Debug.Log("Back");
    }

    void OnTriggerExit(Collider other) {

        if (other.CompareTag("front"))
            mTrigger.SetActive(false);

        if (other.CompareTag("back"))
            mBackTrigger.SetActive(false);
    }

}