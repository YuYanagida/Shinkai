using UnityEngine;

public class ServerTest : MonoBehaviour
{
    void Start()
    {
        //var server = GetComponent<uOSC.uOscServer>();
        //server.onDataReceived.AddListener(OnDataReceived);
    }

    public void OnDataReceived(uOSC.Message message)
    {
        // address (e.g. /uOSC/hoge)
        var msg = message.address + ": ";

        // arguments (object array)
        foreach (var value in message.values)
        {
            if (value is int) msg += (int)value;
            else if (value is float) msg += (float)value;
            else if (value is string) msg += (string)value;
            else if (value is byte[]) msg += "byte[" + ((byte[])value).Length + "]";
        }

        Debug.Log(msg);
    }
}