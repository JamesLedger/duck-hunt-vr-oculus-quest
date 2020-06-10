using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClayMovement : MonoBehaviour
{
    public int counter = 0;

    // Update is called once per frame
    void Update()
    {
        if (counter < 100)
        {
            var velocity = new Vector3(0.3f, 0.3f, 0.3f);
            gameObject.transform.position += velocity;
            counter++;
        }
        else
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            GameObject score = GameObject.Find("Score Number");
            var num = score.GetComponent<TextMeshPro>();

            int scoreInt = int.Parse(num.text);
            scoreInt ++;
            num.text = scoreInt.ToString();

            Destroy(gameObject);
        }
    }
}
