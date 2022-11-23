using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float channceToChangeDirections = 0.1f;
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    private void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position= transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        //простое перемещение
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //изменение направления
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //почати рух вправо
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //почати рух вліво
        }        
    }
    private void FixedUpdate()
    {
        if (Random.value < channceToChangeDirections)
        {
            speed *= -1;

        }
    }
}
