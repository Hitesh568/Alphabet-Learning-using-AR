using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject gorila, dog, lion, goat, gorilass, dogs, lions, goats, rabbit, rabbits, elephant, elephants;

    Vector2 gorilaInitialpos, dogInitialpos, lionInitialpos, goatInitialpos, rabbitInitialpos, elephantInitialpos;
	
    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;

    // Corrected Start method
    void Start()
    {
        gorilaInitialpos = gorila.transform.position;
        dogInitialpos = dog.transform.position;
        lionInitialpos = lion.transform.position;
        goatInitialpos = goat.transform.position;
        rabbitInitialpos = rabbit.transform.position;
        elephantInitialpos = elephant.transform.position;
    }

    public void Draglion()
    {
        lion.transform.position = Input.mousePosition;
    }

    public void Draggorila()
    {
        gorila.transform.position = Input.mousePosition;
    }

    public void Dragdog()
    {
        dog.transform.position = Input.mousePosition;
    }

    public void Draggoat()
    {
        goat.transform.position = Input.mousePosition;
    }

    public void Dragrabbit()
    {
        rabbit.transform.position = Input.mousePosition;
    }

    public void Dragelephant()
    {
        elephant.transform.position = Input.mousePosition;
    }

    public void Droplion()
    {
        float Distance = Vector3.Distance(lion.transform.position, lions.transform.position);
        if (Distance < 50)
        {
            lion.transform.position = lions.transform.position;

            // Check if the correct array has elements before playing sound
            if (correct.Length > 0)
            {
                source.clip = correct[Random.Range(0, correct.Length)];
                source.Play();
            }
        }
        else
        {
            lion.transform.position = lionInitialpos;

            // Play incorrect sound if assigned
            if (incorrect != null)
            {
                source.clip = incorrect;
                source.Play();
            }
        }

    }

    public void Dropgorila()
    {
        float Distance = Vector3.Distance(gorila.transform.position, gorilass.transform.position);
        if (Distance < 50)
        {
            gorila.transform.position = gorilass.transform.position;

            // Check if the correct array has elements before playing sound
            if (correct.Length > 0)
            {
                source.clip = correct[Random.Range(0, correct.Length)];
                source.Play();
            }
        }
        else
        {
            gorila.transform.position = gorilaInitialpos;

            // Play incorrect sound if assigned
            if (incorrect != null)
            {
                source.clip = incorrect;
                source.Play();
            }
        }
    }

    public void Dropdog()
    {
        float Distance = Vector3.Distance(dog.transform.position, dogs.transform.position);
        if (Distance < 50)
        {
            dog.transform.position = dogs.transform.position;

            // Check if the correct array has elements before playing sound
            if (correct.Length > 0)
            {
                source.clip = correct[Random.Range(0, correct.Length)];
                source.Play();
            }
        }
        else
        {
            dog.transform.position = dogInitialpos;

            // Play incorrect sound if assigned
            if (incorrect != null)
            {
                source.clip = incorrect;
                source.Play();
            }
        }
    }

    public void Dropgoat()
    {
        float Distance = Vector3.Distance(goat.transform.position, goats.transform.position);
        if (Distance < 50)
        {
            goat.transform.position = goats.transform.position;

            // Check if the correct array has elements before playing sound
            if (correct.Length > 0)
            {
                source.clip = correct[Random.Range(0, correct.Length)];
                source.Play();
            }
        }
        else
        {
            goat.transform.position = goatInitialpos;

            // Play incorrect sound if assigned
            if (incorrect != null)
            {
                source.clip = incorrect;
                source.Play();
            }
        }
    }

    public void Droprabbit()
    {
        float Distance = Vector3.Distance(rabbit.transform.position, rabbits.transform.position);
        if (Distance < 50)
        {
            rabbit.transform.position = rabbits.transform.position;

            // Check if the correct array has elements before playing sound
            if (correct.Length > 0)
            {
                source.clip = correct[Random.Range(0, correct.Length)];
                source.Play();
            }
        }
        else
        {
            rabbit.transform.position = rabbitInitialpos;

            // Play incorrect sound if assigned
            if (incorrect != null)
            {
                source.clip = incorrect;
                source.Play();
            }
        }
    }

    public void Dropelephant()
    {
        float Distance = Vector3.Distance(elephant.transform.position, elephants.transform.position);
        if (Distance < 50)
        {
            elephant.transform.position = elephants.transform.position;

            // Check if the correct array has elements before playing sound
            if (correct.Length > 0)
            {
                source.clip = correct[Random.Range(0, correct.Length)];
                source.Play();
            }
        }
        else
        {
            elephant.transform.position = elephantInitialpos;

            // Play incorrect sound if assigned
            if (incorrect != null)
            {
                source.clip = incorrect;
                source.Play();
            }
        }
    }
}
