# SOLID_principles
Road2 assignment to test my skills. Implements and explains SOLID principles.

## Single-responsibility principle
[Implementation](https://github.com/MrVatnik/SOLID_principles/blob/main/SOLID_principles/SRP.cs)

SRP is: "A module should be responsible to one, and only one, actor." 

The point of the principle is that a class/structure/method should perform one single task. All functionality of the component must be integral and have high cohesion. This principle is necessary when it is necessary to regulary change the program. 

This principle also helps to simplify the understanding of the code, by simplifying each of its component elements to the simplest tasks that it performs. 

In the case where it is not applied, changes in one object may lead to changes in another, and so on. Once it is applied, all changes that need to be made are minimized.
## Open–closed principle
[Implementation](https://github.com/MrVatnik/SOLID_principles/blob/main/SOLID_principles/OCP.cs)

OCP is: "Software entities ... should be open for extension, but closed for modification." 

The point of this principle is that the system should be built in such a way that all subsequent changes to it should be implemented by adding new code, and not changing existing ones. 

It helps when there is collective work, and everyone is responsible for their own part. When you need to add new functions you shouldn't change some other guy's code, better extend it with yours.
## Liskov substitution principle
[Implementation](https://github.com/MrVatnik/SOLID_principles/blob/main/SOLID_principles/LSP.cs)

LSP is: "Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it." 

That is, in other words, the class S can be considered a subclass of T if replacing T objects with S objects does not lead to a change in the operation of the program. 


The Liskov substitution principle helps to more clearly formulate the class hierarchy, define functionality for base and derived classes, and avoid possible problems when using polymorphism.
## Interface segregation principle
[Implementation](https://github.com/MrVatnik/SOLID_principles/blob/main/SOLID_principles/ISP.cs)

ISP is: "Clients should not be forced to depend upon interfaces that they do not use." 

This principle allows you to avoid overcomplicating interfaces by bloating them and creating often unnecessary fields.
## Dependency inversion principle
[Implementation](https://github.com/MrVatnik/SOLID_principles/blob/main/SOLID_principles/DIP.cs)

DIP is:"Depend upon abstractions, not concretes."

in other words: Abstractions should not depend on details. Details must depend on abstractions. 

This helps by relegating the underlying logic to an abstraction level. Which allows you to add specific implementations after without affecting all other implementations.
