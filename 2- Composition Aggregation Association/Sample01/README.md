# Association, Aggregation and Composition

Relationships between objects

## Association: 

We can say that an association defines the multiplicity among the objects. We can define a one-to-one, one-to-many, many-to-one and many-to-many relationship among objects. Association is a more general term to define a relationship among objects. Association means that an object "uses" another object. 
lives of both objects are independent of each other (each has own lifecycle)
Employee -> Managers

## Aggregation

- Aggregation is a special type of Association. Aggregation is "*the*" relationship among objects. We can say it is a direct association among the objects. In Aggregation, the direction specifies which object contains the other object. There are mutual dependencies among objects.

- For example, departments and employees, a department has many employees but a single employee is not associated with multiple departments.
 
- lives of both objects are independent of each other (each has own lifecycle)
- One object owns the other one

## Composition

Composition is special type of Aggregation. It is a strong type of Aggregation. In this type of Aggregation the child object does not have their own life cycle. The child object's life depends on the parent's life cycle. Only the parent object has an independent life cycle. If we delete the parent object then the child object(s) will also be deleted. We can define the Composition as a "Part of" relationship.
 
 
