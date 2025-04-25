              ABOUT CODE
    By [Fikire Tibebu   ID: DBUR/0737/13]
 Emergency Response Simulation Program
This program simulates emergency response units handling incidents. The user interacts by entering incident types and locations. The units respond if the incident matches their specialization, earning or losing points for valid or invalid interactions.

Feel free to use this Markdown file or let me know if you need any adjustments!

Object-Oriented Programming Concepts Applied

Encapsulation
Encapsulation is achieved through the use of properties like Name and Speed in the EmergencyUnit class, which ensure data is accessed and modified via defined structures.

Inheritance
The Police, Firefighter, and Ambulance classes inherit from the abstract EmergencyUnit class. This allows them to share common properties and methods while implementing their specific behaviors.

Polymorphism
Polymorphism is demonstrated through the use of abstract methods CanHandle() and RespondToIncident(). Each derived class provides its own implementation of these methods.

Abstraction
The EmergencyUnit abstract class provides a blueprint for emergency units, ensuring all derived classes implement the required methods.

Class Structure

Abstract Class: EmergencyUnit Properties

Name (string)
Speed (integer) Methods
CanHandle(string incidentType) (abstract)
RespondToIncident(string incidentType, string location) (abstract)
Emergency Response Simulation - Code Report
