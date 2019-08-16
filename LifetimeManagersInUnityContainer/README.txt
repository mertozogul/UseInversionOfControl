-- Lifetime Managers In Unity Container --

Lifetime Manager	                    Description
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
TransientLifetimeManager:   	        Creates a new object of the requested type every time you call the Resolve or ResolveAll method.
The TransientLifetimeManager is the default lifetime manager.
TransientLifetimeManager is the default manager, if not specified in RegisterType method. 

ContainerControlledLifetimeManager: 	Creates a singleton object first time you call the Resolve or ResolveAll method and then returns the same object on subsequent Resolve or ResolveAll calls.
HierarchicalLifetimeManager:	        Same as the ContainerControlledLifetimeManager, the only difference is that the child container can create its own singleton object. The parent and child containers do not share the same singleton object.
PerResolveLifetimeManager:  	        Similar to the TransientLifetimeManager, but it reuses the same object of registered type in the recursive object graph.
PerThreadLifetimeManager:    	        Creates a singleton object per thread. It returns different objects from the container on different threads.
ExternallyControlledLifetimeManager: 	It maintains only a weak reference of the objects it creates when you call the Resolve or ResolveAll method. It does not maintain the lifetime of the strong objects it creates, and allows you or the garbage collector to control the lifetime of the objects. It enables you to create your own custom lifetime manager.