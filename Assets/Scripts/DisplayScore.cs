using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayScore : MonoBehaviour
{

	private Text text;
	private string prefix;

	// Use this for initialization
	void Start ()
	{
		text = GetComponent<Text>();
		prefix = text.text;
	}
	
	// Update is called once per frame
	void Update ()
	{
		text.text = prefix + GameManager.score.ToString();
	}
}
