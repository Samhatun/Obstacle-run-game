using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

public Transform cube;
public Text scoreText;



void Update () {

scoreText.text = cube.position.z.ToString("0");
//Debug.Log(cube.position.z);

}

}
