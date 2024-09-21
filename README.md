ASP.NET MVC CUSTOMER AND ORDER INFORMATION DISPLAY SERVICE
-
This project involves creating an application using ASP.NET MVC to display customer and order information. It follows the Model-View-Controller (MVC) architecture, separating data presentation from business logic. 
Create Models



Customer Model
-

Create a Customer class to represent customer information.

Id (Unique identifier for the customer, of type int)
FirstName (Customer's first name, of type string)
LastName (Customer's last name, of type string)
Email (Customer's email address, of type string)

Order Model
-

Create an Order class to represent order information.

Id (Unique identifier for the order, of type int)
ProductName (Name of the product, of type string)
Price (Price of the product, of type decimal)
Quantity (Quantity of the product ordered, of type int)

 Create ViewModel
-

CustomerOrderViewModel Class
Create a CustomerOrderViewModel class to hold customer and order information together.

Customer (A Customer object)
Orders (A list of Order objects)
The ViewModel will encapsulate the model data and any additional information required for the view.

Create Controller
-

CustomerOrdersController
Create a CustomerOrdersController class.

Within this controller, create an Index action method.

In the Index method:

Create a sample Customer object and several Order objects.
Use these objects to create a CustomerOrderViewModel object.
Pass the CustomerOrderViewModel object to the view.

Create View
-

Index View
Create a view named Index.cshtml under the Views/CustomerOrders directory.

This view will use the CustomerOrderViewModel to display customer and order information.

In the view:

Display customer information (ID, first name, last name, email).
Create a table for the orders and list order ID, product name, price, and quantity.

Conclusion
-

This project demonstrates how to display customer and order information using ASP.NET MVC. The model classes define the data structure, the ViewModel holds this data together, the controller manages the data flow to the view, and the view presents the data to the user.

Technologies Used
-
C#, HTML, CSS, ASP.NET MVC
