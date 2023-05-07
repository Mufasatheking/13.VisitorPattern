using VisitorPattern;

Console.WriteLine("***Visitor Pattern Demo***\n");
IVisitor visitor = new Visitor();
IVisitor visitor2 = new Visitor2(3);
MyClass myClass = new MyClass();
myClass.Accept(visitor2);
Console.ReadLine();