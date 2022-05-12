using System;

namespace Fulbank.entities;

public abstract class MoneyInterface
{
    // Attributes
    private int _id { get; set; }
    private double _balance { get; set; }
    private DateTime _createdDate { get; set; }
}