namespace HomeWork.ImplementingPrototypePattern;

public class DerivedClass1 : BaseClass, IMyCloneable<DerivedClass1>
{
    public string Derived1Property { get; set; }

    public DerivedClass1(int baseProperty, string derived1Property) : base(baseProperty)
    {
        Derived1Property = derived1Property;
    }

    protected DerivedClass1(DerivedClass1 other) : base(other)
    {
        Derived1Property = other.Derived1Property;
    }

    public override BaseClass Clone()
    {
        return new DerivedClass1(this);
    }

    DerivedClass1 IMyCloneable<DerivedClass1>.Clone()
    {
        return new DerivedClass1(this);
    }
}