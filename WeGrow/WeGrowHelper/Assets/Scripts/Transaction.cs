using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transaction : MonoBehaviour
{
    public enum Frequency { Yearly, Monthly, Weekly, Daily, Hourly, OneTime }

    public decimal MoneyAmount { get; set; }
    public Frequency frequency { get; set; }
}
