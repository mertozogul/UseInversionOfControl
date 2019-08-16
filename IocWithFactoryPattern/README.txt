--IOC With Factory Pattern--

We create low level module factory class to create low level module object for high level module. 
Thus we  make 'loosely coupled' design. But  we can't make it literally.

So that we must use dependeny inversion principle to make 'loosely coupled' design literally. 


In this chapter, we will learn about IoC and how to implement it. This is the first step towards achieving loose coupled design, as illustrated by the following figure:

![github-small](https://www.tutorialsteacher.com/Content/images/ioc/ioc-step1.png) 

Inversion of Control (IoC) is a design principle (although, some people refer to it as a pattern).
As the name suggests, it is used to invert different kinds of controls in object-oriented design to achieve loose coupling.


--we use simple typical n-tier architecture to show to understand DI and strategy pattern, DIP, Factory Pattern.

![github-small](https://www.tutorialsteacher.com/Content/images/ioc/demo-architecture.png)

In an object-oriented design, classes should be designed in a loosely coupled way. 
Loosely coupled means changes in one class should not force other classes to change, 
so the whole application can become maintainable and extensible. 
Let's understand this by using typical n-tier architecture as depicted by the following figure:
In the typical n-tier architecture, the User Interface (UI) uses Service layer to retrieve or save data. 
The Service layer uses the BusinessLogic class to apply business rules on the data. 
The BusinessLogic class depends on the DataAccess class which retrieves or saves the data to the underlying database. 
This is simple n-tier architecture design. Let's focus on the BusinessLogic and DataAccess classes to understand IoC.

The following pattern (but not limited) implements the IoC principle.

![github-small](https://www.tutorialsteacher.com/Content/images/ioc/ioc-patterns.png)


As you can see, the CustomerBusinessLogic class uses the DataAccessFactory.GetCustomerDataAccessObj() method to get an object of the DataAccess class 
instead of creating it using the new keyword. 
Thus, we have inverted the control of creating an object of a dependent class from the CustomerBusinessLogic class to the DataAccessFactory class.
This is a simple implementation of IoC and the first step towards achieving fully loose coupled design. 
As mentioned in the previous chapter, we will not achieve complete loosely coupled classes by only using IoC. 
Along with IoC, we also need to use DIP, Strategy pattern, and DI (Dependency Injection).
