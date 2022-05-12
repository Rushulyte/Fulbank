using System;

namespace Fulbank.entities;

public abstract class Operation
{
    // Attributes
    private int _id { get; set; }
    private double _amount { get; set; }
    private DateTime _createdDate { get; set; }
}