﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transaction : MonoBehaviour
{
    public enum Frequency { Yearly, Monthly, Weekly, Daily, Hourly, OneTime }

    public Guid GUID { get; set; }
    public Guid OwnerGUID { get; set; }
    public string Name { get; set; }
    public decimal MoneyAmount { get; set; }
    public Frequency frequency { get; set; }
    public DateTime startTime { get; set; }
}
