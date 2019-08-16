--Dependency Inversion Principle--

In the previous chapter, we learned about implementing the IoC principle using the Factory pattern and achieved the first level of loosely coupled design. 
Here, we will learn how to implement the Dependency Inversion Principle as the second step to achieve loosely coupled classes.

DIP Definition
DIP is one of the SOLID object-oriented principle invented by Robert Martin (a.k.a. Uncle Bob)

1--> High-level modules should not depend on low-level modules. Both should depend on the abstraction.
2--> Abstractions should not depend on details. Details should depend on abstractions.


In English, abstraction means something which is non-concrete. 
In programming terms, the above CustomerBusinessLogic and DataAccess are concrete classes, meaning we can create objects of them. 
So, abstraction in programming means to create an interface or an abstract class which is non-concrete. 
This means we cannot create an object of an interface or an abstract class. 
As per DIP, CustomerBusinessLogic (high-level module) should not depend on the concrete DataAccess class (low-level module). 
Both classes should depend on abstractions, meaning both classes should depend on an interface or an abstract class.

