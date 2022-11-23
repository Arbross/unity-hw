using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for(int i =0; i< numBaskets; i++)
        {
            GameObject tBasket = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasket.transform.position = pos;
            basketList.Add(tBasket);
        }
    }
    public void AppleDestroyed()
    {
        GameObject[] delList = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject apple in delList)
        {
            Destroy(apple);
        }
        int delIndex = basketList.Count-1;
        GameObject basket= basketList[delIndex];
        basketList.RemoveAt(delIndex);
        Destroy(basket);

        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("_Scene_0");
        }
    }
}
