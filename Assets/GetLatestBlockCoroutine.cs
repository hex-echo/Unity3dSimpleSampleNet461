using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Nethereum.JsonRpc.UnityClient;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Util;
using System.Diagnostics;

public class GetLatestBlockCoroutine : MonoBehaviour
{
    public string Url = "https://mainnet.infura.io";
    public string UrlFull = "https://127.0.0.1:8545";

    public InputField ResultBlockNumber;
    public InputField InputUrl;

    // Use this for initialization
    void Start()
    {
        InputUrl.text = Url;
        GetBlockNumber();
    }

    public void GetBlockNumberRequest()
    {
        StartCoroutine(GetBlockNumber());
    }

    public IEnumerator GetBlockNumber()
    {

       var blockNumberRequest = new EthBlockNumberUnityRequest(UrlFull);
 
       yield return blockNumberRequest.SendRequest();

        if (blockNumberRequest.Exception != null)
        {
            UnityEngine.Debug.Log(blockNumberRequest.Exception.Message);
        }
        else
        {
            ResultBlockNumber.text = blockNumberRequest.Result.Value.ToString();
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
