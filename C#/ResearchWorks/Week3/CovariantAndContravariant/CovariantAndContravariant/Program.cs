Base x = new Base();
Base y = new Derived();

x.DoSomething();
y.DoSomething();

//y.DoMore(); HATA!

Derived z = new Derived();
z.DoSomething();
z.DoMore();

// Covariant
IProducer<Base> prodOfBase = null!;
Base a = prodOfBase.Produce();
//Derived k = prodOfBase.Produce(); HATA!

IProducer<Derived> prodOfDerived = null!;
Derived b = prodOfDerived.Produce();
Base c = prodOfDerived.Produce();


// Contravariant
IConsumer<Base> consOfBase = null!;
consOfBase.Consume(new Base());
consOfBase.Consume(new Derived());

IConsumer<Derived> consOfDerived = null!;
consOfDerived.Consume(new Derived());
//consOfDerived.Consume(new Base()); HATA!


IProducer<Base> p = prodOfBase; // IProducer<Base>
IProducer<Base> q = prodOfDerived; // IProducer<Derived>
IProducer<Derived> r = prodOfDerived; // IProducer<Derived>
//IProducer<Derived> s = prodOfBase; IProducer<Base> HATA!

IConsumer<Derived> t = consOfDerived; // IConsumer<Derived>
IConsumer<Derived> u = consOfBase; // IConsumer<Base>
IConsumer<Base> v = consOfBase; // IConsumer<Base>
//IConsumer<Base> w = consOfDerived; // IConsumer<Derived> HATA!

interface IProducer<out T> // Covariant
{
    T Produce();
}

interface IConsumer<in T> //Contravariant
{
    void Consume(T obj);
}

class Base
{
    public void DoSomething() => Console.WriteLine($"Doing from {this.GetType().Name}");
}

class Derived : Base
{
    public void DoMore() => Console.WriteLine($"Doing more from {this.GetType().Name}");
}