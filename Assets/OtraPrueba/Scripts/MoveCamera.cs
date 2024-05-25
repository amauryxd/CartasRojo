using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public int count = 1;
    public GameObject nocamara;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (count)
        {
            case 1: nocamara.transform.position = new Vector3(nocamara.transform.position.x, nocamara.transform.position.y, -26f);
                break;
            case 2: nocamara.transform.position = new Vector3(nocamara.transform.position.x, nocamara.transform.position.y, 4474f);
                break;
            case 3: nocamara.transform.position = new Vector3(nocamara.transform.position.x, nocamara.transform.position.y, 8974);
                break;
            case 4: nocamara.transform.position = new Vector3(nocamara.transform.position.x, nocamara.transform.position.y, 13474);
                break;
            case 5: nocamara.transform.position = new Vector3(nocamara.transform.position.x, nocamara.transform.position.y, 17974);
                break;
            case 6: nocamara.transform.position = new Vector3(nocamara.transform.position.x, nocamara.transform.position.y, 22474);
                break;
            case 7: nocamara.transform.position = new Vector3(nocamara.transform.position.x, nocamara.transform.position.y, 26974);
                break;
            case 8: nocamara.transform.position = new Vector3(nocamara.transform.position.x, nocamara.transform.position.y, 31474);
                break;
            case 9: nocamara.transform.position = new Vector3(nocamara.transform.position.x, nocamara.transform.position.y, -13526);
                break;
        }
    }

    public void movinDerecha()
    {
        if(!(count > 7))
            count++;


    }
    public void movinIzqu()
    {
        if (!(count < 2))
            count--;
    }

    public void btnRandom()
    {
        count = 9;
    }
    public void btnRegresar()
    {
        count = 1;
    }
}
