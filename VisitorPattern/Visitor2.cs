namespace VisitorPattern
{ 
    class Visitor2 :IVisitor
    {
        private readonly int _multiplyValue;

        public Visitor2(int multiplyValue)
        {
            _multiplyValue = multiplyValue;
        }
        public void Visit(MyClass myClassElement)
        {
            Console.WriteLine("Visitor2 is trying to change the integer value via multiplication");
            myClassElement.MyInt = myClassElement.MyInt* _multiplyValue;
            Console.WriteLine("Exiting from Visitor2.");
        }
    }
}