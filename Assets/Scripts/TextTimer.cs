using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextTimer : MonoBehaviour
{
	private Text text;
	private float time = 0.0f;

	// Use this for initialization
	void Start ()
	{
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		time += Time.deltaTime;
		text.text = time.ToString("f2");
	}
}
