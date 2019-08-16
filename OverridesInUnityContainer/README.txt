-- Overrides In Unity Container  --

Unity container allows us to override a registered type by using ResolverOverride. 
ResolverOverride is an abstract class that provides implementation for overriding registration. 
There are three important classes which inherit ResolverOverride:

1--> ParameterOverride: Used to override constructor parameters.
2--> PropertyOverride: Used to override the value of a specified property.
3--> DependencyOverride: Used to override the type of dependency and its value.
**DependencyOverride class dependency'nin  constructor, property, method boyunca  hangisi ile sağlandığına bakılmaksızın dependency'nin tipini ve değerini override etmek için kullanılabilir.
The DependencyOverride class can be used to override the type of dependency and its value, irrespective of whether dependencies are provided through a constructor, a property or a method. 
  
           