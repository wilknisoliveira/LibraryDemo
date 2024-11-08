# LibraryDemo

![CSharp](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)

This application is an implementation concept of the Package-By-Component approach, presented by Simon Brown in the "Missing Chapter" of "Clean Architecture" book (Robert C. Martin). 

The application business idea started with Spring I/O Talk by Maciej Walkowiak (https://www.youtube.com/watch?v=VGhg6Tfxb60).

To structure the folders, I used a similar organization from Explicit Architecture (https://herbertograca.com/2017/11/16/explicit-architecture-01-ddd-hexagonal-onion-clean-cqrs-how-i-put-it-all-together/), adapting somethings to specific necessities. The result is:
<img style="width:400px" src="Assets\Architecture.png" alt="Architecture">

The most important ideia is decouple the components. To enable the comunication between these components was used two mechanism:
- Events to target a service outside the event publisher component.
	- To make it happen, the MediatR was implement to publish and listening the events;
	<img style="width:400px" src="Assets\Mediator.png" alt="Mediator">
- Dependency Inversion Principle from SOLID to get informations from other component;
	<img style="width:400px" src="Assets\DependencyInversion.png" alt="DependencyInversion">

So, was necessity the used of a Shared component (idea from Expicit Achitecture) to available the two approachs presented above.

 ## Author
 Wilknis Deyvis

 [![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/wilknis/)
