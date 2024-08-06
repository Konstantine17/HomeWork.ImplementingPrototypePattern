namespace HomeWork.ImplementingPrototypePattern;

public class FinalClass : DerivedClass2, IMyCloneable<FinalClass>
{
    public bool FinalProperty { get; set; }

    public FinalClass(int baseProperty, string derived1Property, double derived2Property, bool finalProperty) : base(
        baseProperty, derived1Property, derived2Property)
    {
        FinalProperty = finalProperty;
    }

    protected FinalClass(FinalClass other) : base(other)
    {
        FinalProperty = other.FinalProperty;
    }

    public override BaseClass Clone()
    {
        return new FinalClass(this);
    }

    FinalClass IMyCloneable<FinalClass>.Clone()
    {
        return new FinalClass(this);
    }
}