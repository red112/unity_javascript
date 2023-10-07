using UnityEngine;
using System.Runtime.InteropServices;

public class IF : MonoBehaviour
{

    [DllImport("__Internal")]
    public static extern void Hello();

    [DllImport("__Internal")]
    public static extern void HelloString(string str);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
