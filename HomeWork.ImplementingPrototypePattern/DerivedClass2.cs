namespace HomeWork.ImplementingPrototypePattern;

public class DerivedClass2 : DerivedClass1, IMyCloneable<DerivedClass2>
{
    public double Derived2Property { get; set; }

    public DerivedClass2(int baseProperty, string derived1Property, double derived2Property) : base(baseProperty,
        derived1Property)
    {
        Derived2Property = derived2Property;
    }

    protected DerivedClass2(DerivedClass2 other) : base(other)
    {
        Derived2Property = other.Derived2Property;
    }

    public override BaseClass Clone()
    {
        return new DerivedClass2(this);
    }

    DerivedClass2 IMyCloneable<DerivedClass2>.Clone()
    {
        return new DerivedClass2(this);
    }
}