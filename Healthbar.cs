using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Healthbar : MonoBehaviour
{
    Slider slider;
    public Gradient gradient;
    public Image fill;
    Animator animator;


    public int currenthealth;
    public int maxhealth = 100;
    void Start()
    {
        currenthealth = maxhealth;
        //SetMaxHealth(maxhealth);
        slider = GetComponent<Slider>();
    }
    void Update()
    {
        //if player health == 0, game resets
        if (currenthealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (animator != null)
        {

            animator.SetInteger("Health", currenthealth);
        }
    }
    public void takedamage(int damage)
    {
        currenthealth -= damage;

        SetHealth(currenthealth);
    }
    //public void SetMaxHealth(int health)
    //{
    //    slider.maxValue = health;
    //    slider.value = health;

    //    fill.color = gradient.Evaluate(1f);
    //}
    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }




}
