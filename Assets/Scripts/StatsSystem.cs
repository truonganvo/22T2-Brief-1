using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    private int Newagility;
    private int Newintelligence;
    private int Newstrength;

    private int Newstyle;
    private int Newluck;
    private int Newrhythm;

    // Our variables used to determine our fighting power.
    public int style;
    public int luck;
    public int rhythm;

    private void Start()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        strength = Random.Range(0, 10);
        agility = Random.Range(0, 10);
        intelligence = Random.Range(0, 10); /*Add private void Update to distribute 20 points among all the stats*/

        // Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log("Strength " + strength);
        Debug.Log("Agility " + agility);
        Debug.Log("Interlligence " + intelligence);

        if (strength + agility + intelligence >= 20)
        {
            _ = (strength + agility + intelligence == 20);
        }

        // let's create some float temporary variables to hold our multiplier values.
        // create an agility multiplier should be set to 0.5
        float tempAgilityFloat = (int)((int)(float)agility * 0.5);

        // create a strength multiplier should be set to 1
        int tempStrengthInt = strength * 1;

        // create an intelligence multiplier should be set to 2.
        int tempIntelligenceInt = intelligence * 2;

        // Debug out our current multiplier values.
        Debug.Log("Temp Strength " + tempStrengthInt);
        Debug.Log("Temp Agility " + tempAgilityFloat);
        Debug.Log("Temp Intelligence " + tempIntelligenceInt);

        // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values.
        // style should be based off our strength and be converted at a rate of 1 : 1.
        style = strength * 1;

        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        luck = (int)(intelligence * (float)1.5);

        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
         rhythm = (int)(agility * (float)0.5);

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log("Style:" + style);
        Debug.Log("Luck:" + luck);
        Debug.Log("Rhythm" + rhythm);

        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10;
        Newstrength = strength + (int)additionalPoints / 3;
        Newagility = agility + (int)additionalPoints / 3;
        Newintelligence = intelligence + (int)additionalPoints / 3;

        if (Newstrength + Newagility + Newintelligence >= 30)
        {
            _ = (Newstrength + Newagility + Newintelligence == 30);
        }

        // Debug out our new physical stat values
        Debug.Log("New Strength: " + Newstrength);
        Debug.Log("New Agility: " + Newagility);
        Debug.Log("New Intelligence: " + Newintelligence);

        // let's recalculate our style, luck and rhytmn as our initial stats have changed.
        Newstyle = Newstrength * 1;
        float Newluck = Newintelligence * (float)1.5;
        float Newrhythm = Newagility * (float)0.5;

        // Debug out our new dancing stat values
        Debug.Log("NewStyle " + Newstyle);
        Debug.Log("NewLuck " + Newluck);
        Debug.Log("NewRhythm " + Newrhythm);

    }
}
