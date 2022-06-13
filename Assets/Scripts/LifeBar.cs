using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{

	public Slider slider;
	public Image fill;

	public void SetMaxLife(int life)
	{
		slider.maxValue = life;
		slider.value = life;

	}

    public void SetLife(int life)
	{
		slider.value = life;
	}

}