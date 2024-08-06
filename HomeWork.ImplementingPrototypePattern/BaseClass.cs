namespace HomeWork.ImplementingPrototypePattern;

public class BaseClass : IMyCloneable<BaseClass>, ICloneable
{
    public int BaseProperty { get; set; }
    
    public BaseClass(int baseProperty)
    {
        BaseProperty = baseProperty;
    }

    protected BaseClass(BaseClass other)
    {
        BaseProperty = other.BaseProperty;
    }

    public virtual BaseClass Clone()
    {
        return new BaseClass(this);
    }

    object ICloneable.Clone()
    {
        return Clone();
    }
}