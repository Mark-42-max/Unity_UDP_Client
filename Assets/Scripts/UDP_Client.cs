using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class UDP_Client : MonoBehaviour
{
    private Transform t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        UDPTest(transform);
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(new Vector3(transform.position.x, transform.position.y, transform.position.z + 1));
        }
    }

    void UDPTest (Transform t)
    {
        UdpClient client = new UdpClient(5600);
        try
        {
            client.Connect("127.0.0.1", 5400);
            byte[] sendBt = Encoding.ASCII.GetBytes(t.position.ToString());
            client.Send(sendBt, sendBt.Length);

            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 5400);
            byte[] receiveBytes = client.Receive(ref remoteEndPoint);
            string received = Encoding.ASCII.GetString(receiveBytes);

            print("Message received from the server: " + StringToVector3(received));
        }
        catch(Exception e)
        {
            print("Error message: " + e.Message);
        }
    }

    private Vector3 StringToVector3(string sVector)
    {
        // Remove the parentheses
        if (sVector.StartsWith("(") && sVector.EndsWith(")"))
        {
            sVector = sVector.Substring(1, sVector.Length - 2);
        }

        // split the items
        string[] sArray = sVector.Split(',');

        // store as a Vector3
        Vector3 result = new Vector3(
            float.Parse(sArray[0]),
            float.Parse(sArray[1]),
            float.Parse(sArray[2]));

        return result;
    }
}
