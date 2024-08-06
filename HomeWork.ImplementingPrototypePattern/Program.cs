using HomeWork.ImplementingPrototypePattern;

var original = new FinalClass(1, "Test", 3.14, true);
var cloned = ((IMyCloneable<FinalClass>)original).Clone();

Console.WriteLine($"Original: {original.BaseProperty}, {original.Derived1Property}, {original.Derived2Property}, {original.FinalProperty}");
Console.WriteLine($"Cloned: {cloned.BaseProperty}, {cloned.Derived1Property}, {cloned.Derived2Property}, {cloned.FinalProperty}");

//Проверка на глубокое копирование

cloned.BaseProperty = 2;
cloned.Derived1Property = "Changed";
cloned.Derived2Property = 2.78;
cloned.FinalProperty = false;

Console.WriteLine($"Original after change: {original.BaseProperty}, {original.Derived1Property}, {original.Derived2Property}, {original.FinalProperty}");
Console.WriteLine($"cloned after change: {cloned.BaseProperty}, {cloned.Derived1Property}, {cloned.Derived2Property}, {cloned.FinalProperty}");
