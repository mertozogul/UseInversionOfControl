--IOC With Dependency Injection Pattern (We use strategy pattern with dependency injection)--

In the previous chapter, related to DIP, we created and used abstraction to make the classes loosely coupled. 
Here, we are going to implement Dependency Injection and strategy pattern together to move the dependency object creation completely out of the class. 
This is our third step in making the classes completely loose coupled.

![github-small](https://www.tutorialsteacher.com/Content/images/ioc/ioc-step3.png) 

*************DEPENDENCY INJECTION (DI) IS A DESIGN PATTERN USED TO IMPLEMENT IOC.*****

It allows the creation of dependent objects outside of a class and provides those objects to a class through different ways. 
Using DI, we move the creation and binding of the dependent objects outside of the class that depends on them.

The Dependency Injection pattern involves 3 types of classes.

Client Class: The client class (dependent class) is a class which depends on the service class
Service Class: The service class (dependency) is a class that provides service to the client class.
Injector Class: The injector class injects the service class object into the client class.
The following figure illustrates the relationship between these classes:

![github-small](https://www.tutorialsteacher.com/Content/images/ioc/DI.png) 

--Types of Dependency Injection--

As you have seen above, the injector class injects the service (dependency) to the client (dependent). 
The injector class injects dependencies broadly in three ways: through a constructor, through a property, or through a method.

Constructor Injection: In the constructor injection, the injector supplies the service (dependency) through the client class constructor.

Property Injection: In the property injection (aka the Setter Injection), the injector supplies the dependency through a public property of the client class.

Method Injection: In this type of injection, the client class implements an interface which declares the method(s) to supply the dependency 
                  and the injector uses this interface to supply the dependency to the client class.

The following figure illustrates the DI pattern implementation:

![github-small](https://www.tutorialsteacher.com/Content/images/ioc/DI-example.png)




In the above example, the CustomerBusinessLogic class implements the IDataAccessDependency interface, which includes the SetDependency() mehtod. 
So, the injector class (CustomerService) will now use this method to inject the dependent class (CustomerDataAccess) to the client class.

Thus, you can use DI and strategy pattern to create loose coupled classes.

So far, we have used several principles and patterns to achieve loosely coupled classes. 
In professional projects, there are many dependent classes and implementing these patterns is time consuming. 
Here the IoC Container (aka the DI container) helps us. 