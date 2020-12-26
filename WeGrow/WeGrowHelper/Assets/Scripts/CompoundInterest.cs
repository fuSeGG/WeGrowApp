using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class CompoundInterest : MonoBehaviour
{
    private const double e = 2.7183;

    // Start is called before the first frame update
    void Start()
    {
        CalcCompoundInterest(10000, 0.15, 12, 1);
        CalcCompoundInterestContinuous(10000, 0.15, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// CompoundInterest not Continuous
    /// </summary>
    static double CalcCompoundInterest(double principal, double interestRate, int timesPerYear, double years)
    {
        // (1 + r/n)
        double body = 1 + (interestRate / timesPerYear);

        // nt
        double exponent = timesPerYear * years;

        // P(1 + r/n)^nt        
        var result = principal * Math.Pow(body, exponent);
        Debug.Log(result);
        return result;
    }

    /// <summary>
    /// CompoundInterest Continuous
    /// </summary>
    static double CalcCompoundInterestContinuous(double principal, double interestRate, double years)
    {
        // (1 + r/n)
        double body = e;

        // nt
        double exponent = interestRate * years;

        // PV x e ^(i x t)
        // PV = the present value of the investment
        // i = the stated interest rate
        // n = the number of compounding periods
        // t = the time in years

        var result = principal * Math.Pow(body, exponent);
        Debug.Log(result);
        return result;
    }

}
