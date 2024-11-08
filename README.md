# LibraryDemo

![CSharp](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)

This application is an implementation concept of the Package-By-Component approach, presented by Simon Brown in the "Missing Chapter" of "Clean Architecture" book (Robert C. Martin). 

The application business idea started with Spring I/O Talk by Maciej Walkowiak (https://www.youtube.com/watch?v=VGhg6Tfxb60).

To structure the folders, I used a similar organization from Explicit Architecture (https://herbertograca.com/2017/11/16/explicit-architecture-01-ddd-hexagonal-onion-clean-cqrs-how-i-put-it-all-together/), adapting somethings to specific necessities. The result is:
<img style="width:400px" src="Assets\Architecture.png" alt="Architecture">

The most important idea is decoupling the components. To enable communication between these components I used two mechanisms:
- Events to target a service outside the event publisher component.
	- To make it happen, the MediatR was implemented to publish and listening the events;
	<img style="width:400px" src="Assets\Mediator.png" alt="Mediator">
- Dependency Inversion Principle from SOLID to get information from another component;
	<img style="width:400px" src="Assets\DependencyInversion.png" alt="DependencyInversion">

So, it was necessary to create a Shared component (idea from Expicit Architecture) to enable the two approaches presented above.

 ## Author
 Wilknis Deyvis

 [![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/wilknis/)
